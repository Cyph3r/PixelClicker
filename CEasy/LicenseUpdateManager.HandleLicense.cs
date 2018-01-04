using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using CEasy.Model;
using CEasy.Types;
using Newtonsoft.Json;
using EventLog = CEasy.Model.EventLog;

namespace CEasy
{
    public partial class LicenseUpdateManager
    {
        protected class HandleLicense : CEasyHandler
        {
            public readonly LocalVersionRequestModel LocalVersionRequestModel;
            public RemoteVersionResponseModel RemoteVersionResponseModel;
            public HandleLicense(LocalVersionRequestModel localVersionRequestModel)
            {

                this.LocalVersionRequestModel = localVersionRequestModel;
                this.RemoteVersionResponseModel = new RemoteVersionResponseModel();
            }

            public override bool OnResponse(IResponse response)
            {
                var license_version = 4;

                try
                {
                    if (license_version == 1)
                    {
                        var retSplit = response.Value.Split('|');
                        if (retSplit[0] == "1" && retSplit[1] == (LocalVersionRequestModel.test * 5 + LocalVersionRequestModel.test).ToString())
                        {
                            response.EventLog = new EventLog(Event.Success,
                                $"Authentication Successful! License version: {license_version}");
                            RemoteVersionResponseModel = new RemoteVersionResponseModel { success = true };
                            return true;
                        }
                        response.EventLog = new EventLog(Event.Warning,
                            $"Authentication Unsuccessful! License version: {license_version}");
                        RemoteVersionResponseModel = new RemoteVersionResponseModel { success = false };
                        return false;
                    }

                    if (license_version == 2 || license_version == 3)
                    {
                        RemoteVersionResponseModel = JsonConvert.DeserializeObject<RemoteVersionResponseModel>(response.Value);

                        if (RemoteVersionResponseModel.success &&
                            RemoteVersionResponseModel.test_result == LocalVersionRequestModel.test * 5 + LocalVersionRequestModel.test)
                        {
                            response.EventLog = new EventLog(Event.Success,
                                $"Authentication Successful!  License version: {license_version}");
                            return true;
                        }
                        response.EventLog = new EventLog(Event.Warning,
                            $"Authentication Unsuccessful! success: {RemoteVersionResponseModel.success} math stuff: {RemoteVersionResponseModel.test_result} == {LocalVersionRequestModel.test * 5 + LocalVersionRequestModel.test} Test Number: {LocalVersionRequestModel.test} License version: {license_version}");
                        return false;
                    }

                    if (license_version == 4)
                    {
                        Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
                        string nearest10ThOfASecond = unixTimestamp - (unixTimestamp % 30) + "4159871549876553177127";

                        var temp = DecryptRJ256(Convert.FromBase64String(response.Value), "pzrwrm8814f953+22#bbtz3qq=372j5z", nearest10ThOfASecond);

                        RemoteVersionResponseModel = JsonConvert.DeserializeObject<RemoteVersionResponseModel>(temp);

                        if (RemoteVersionResponseModel.success &&
                            RemoteVersionResponseModel.test_result == LocalVersionRequestModel.test * 5 + LocalVersionRequestModel.test)
                        {
                            response.EventLog = new EventLog(Event.Success,
                                $"Authentication Successful!  License version: {license_version}");
                            return true;
                        }
                        response.EventLog = new EventLog(Event.Warning,
                            $"Authentication Unsuccessful! success: {RemoteVersionResponseModel.success} math stuff: {RemoteVersionResponseModel.test_result} == {LocalVersionRequestModel.test * 5 + LocalVersionRequestModel.test} Test Number: {LocalVersionRequestModel.test} License version: {license_version}");
                        return false;
                    }

                }
                catch (Exception ex)
                {
                    response.EventLog = new EventLog(Event.Exception, $"Authentication Unsuccessful! License version: {license_version}", ex);
                    return false;
                }

                return false;
            }

            public static String DecryptRJ256(byte[] cypher, string KeyString, string IVString)
            {
                var sRet = "";

                var encoding = new UTF8Encoding();
                var Key = encoding.GetBytes(KeyString);
                var IV = encoding.GetBytes(IVString);

                using (var rj = new RijndaelManaged())
                {
                    try
                    {
                        rj.Padding = PaddingMode.PKCS7;
                        rj.Mode = CipherMode.CBC;
                        rj.KeySize = 256;
                        rj.BlockSize = 256;
                        rj.Key = Key;
                        rj.IV = IV;
                        var ms = new MemoryStream(cypher);

                        using (var cs = new CryptoStream(ms, rj.CreateDecryptor(Key, IV), CryptoStreamMode.Read))
                        {
                            using (var sr = new StreamReader(cs))
                            {
                                sRet = sr.ReadLine();
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        rj.Clear();
                    }
                }

                return sRet;
            }
        }
    }
}
