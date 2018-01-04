using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using CEasy.Model;
using CEasy.Types;

namespace CEasy
{
    public partial class LicenseUpdateManager
    {
        protected class HandleUpdate : CEasyHandler
        {
            private string _tempPath;
            public RemoteVersionResponseModel RemoteVersionResponseModel;
            public HandleUpdate(RemoteVersionResponseModel remoteVersionResponseModel)
            {
                RemoteVersionResponseModel = remoteVersionResponseModel;
            }

            public override async Task<bool> OnRequest(IRequest request)
            {
                try
                {
                    _tempPath = Path.GetTempFileName();
                    var webClient = new WebClient();
                    await webClient.DownloadFileTaskAsync(request.Uri, _tempPath);
                    request.EventLog = new EventLog(Event.Success, $"File downloaded to {_tempPath} Successfully!");
                    return true;
                }
                catch (Exception ex)
                {
                    request.EventLog = new EventLog(Event.Success, "File downloaded unsuccessfully!", ex);
                    return false;
                }
            }

            public override bool OnResponse(IResponse response)
            {
                string md5Hash = GetMd5HashFromFile(_tempPath);
                if (!md5Hash.Equals(RemoteVersionResponseModel.file_hash))
                {
                    File.Delete(_tempPath);
                    response.EventLog = new EventLog(Event.Exception,
                                $"Unexpected md5 hash! Expected {RemoteVersionResponseModel.file_hash} and got {md5Hash}.  Deleting downloaded file: {_tempPath}");
                    return false;
                }
                else
                {
                    try
                    {
                        string tempDir = "./downloadtemp";
                        if (Directory.Exists(tempDir))
                            Directory.Delete(tempDir, true);

                        ZipFile.ExtractToDirectory(_tempPath, tempDir);
                        new DirectoryInfo(tempDir).Attributes |= FileAttributes.Hidden;

                        foreach (string file in Directory.GetFiles(tempDir, "*.*", SearchOption.AllDirectories))
                        {
                            string str2 = file.Replace(tempDir, ".");
                            string str3 = str2 + ".old";

                            if (File.Exists(str3))
                                File.Delete(str3);
                            if (File.Exists(str2))
                                File.Move(str2, str3);

                            File.Copy(file, str2, true);
                        }

                        Directory.Delete(tempDir, true);
                        response.EventLog = new EventLog(Event.Success,$"Successfully updated!");
                        return true;
                    }
                    catch (Exception ex)
                    {
                        response.EventLog = new EventLog(Event.Exception, $"Unsuccessfully updated!", ex);
                        return false;
                    }
                }
            }

            private static string GetMd5HashFromFile(string fileName)
            {
                FileStream fileStream = new FileStream(fileName, FileMode.Open);
                byte[] hash = new MD5CryptoServiceProvider().ComputeHash(fileStream);
                fileStream.Close();
                StringBuilder stringBuilder = new StringBuilder();
                for (int index = 0; index < hash.Length; ++index)
                    stringBuilder.Append(hash[index].ToString("x2"));
                return stringBuilder.ToString();
            }
        }
    }
}
