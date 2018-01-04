using System;
using System.IO;
using System.Threading.Tasks;
using CEasy.Model;
using CEasy.Types;
using EventLog = CEasy.Model.EventLog;

namespace CEasy
{
    public partial class LicenseUpdateManager : CEasy
    {
        public bool UpdateAvaliable { get; set; }
        public string ProductName { get; }
        public string ProductVersion { get; }
        public RemoteVersionResponseModel RemoteVersionResponse { get; private set; }
        private static readonly Random _rnd = new Random();
        private static readonly object _syncLock = new object();
        public bool willpay { get; set; } = false;
        public bool voted { get; set; } = false;
        public double suggestedprice { get; set; } = 0.00;
        public string email { get; set; } = "";
        public string username { get; set; } = "";
        public string password { get; set; } = "";

        private readonly Uri _uri;

        public LicenseUpdateManager(string uri, string productName, string productVersion)
        {
            _uri = new Uri(uri);
            ProductName = productName;
            ProductVersion = productVersion;
        }
        public async Task<bool> CheckLicense()
        {
            CleanUpOldFiles();

            LocalVersionRequestModel newLocalVersionRequest = new LocalVersionRequestModel
            {
                test = GetRandomNumber(100000, 999999),
                product_name = ProductName,
                product_version = ProductVersion,
                username = this.username,
                password = this.password
             
            };


            HandleLicense handleLicense = new HandleLicense(newLocalVersionRequest);
            IRequest licenseRequest;

            if (voted)
            {
                newLocalVersionRequest.voted = this.voted;
                newLocalVersionRequest.willpay = this.willpay;
                newLocalVersionRequest.suggestedprice = this.suggestedprice;
                newLocalVersionRequest.email = this.email;

                licenseRequest = new Request(_uri, newLocalVersionRequest.GetUrlEncodedContentVote(), handleLicense);
            }
            else
            {
                licenseRequest = new Request(_uri, newLocalVersionRequest.GetUrlEncodedContent(), handleLicense);
            }


            var isLicensed = await DoRequests(licenseRequest);

            this.RemoteVersionResponse = handleLicense.RemoteVersionResponseModel;

            UpdateAvaliable = RemoteVersionResponse.update_needed;

            return isLicensed;
            
        }
        public static int GetRandomNumber(int min, int max)
        {
            lock (_syncLock)
            { // synchronize
                return _rnd.Next(min, max);
            }
        }
        public async Task<bool> Update()
        {
            HandleUpdate handleUpdate = new HandleUpdate(RemoteVersionResponse);
            IRequest downloadRequest = new Request(new Uri(RemoteVersionResponse.update_url), null, handleUpdate);
            var isInstalled = await DoRequests(downloadRequest);
            this.RemoteVersionResponse = handleUpdate.RemoteVersionResponseModel;

            return isInstalled;
        }

        private void CleanUpOldFiles()
        {
            try
            {
                foreach (string file in Directory.GetFiles(".", "*.old*", SearchOption.AllDirectories))
                {
                    if (File.Exists(file))
                    {
                        File.Delete(file);
                        OnEventLogAdded(new EventLog(Event.Success, $"deleted {file}"));
                    }
                }
            }
            catch (Exception ex)
            {
                OnEventLogAdded(new EventLog(Event.Exception, "Failed to delete old files!", ex));
            }
        }
    }
}