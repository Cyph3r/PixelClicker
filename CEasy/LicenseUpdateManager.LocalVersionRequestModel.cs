using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CEasy
{
    public partial class LicenseUpdateManager
    {
        public class LocalVersionRequestModel
        {
            public string username { get; set; }
            public string password { get; set; }
            public int test { get; set; }
            public string product_name { get; set; }
            public string product_version { get; set; }
            private string mac_id { get; } = CEasy.FingerPrint;
            private string fingerprint { get; } = CEasy.MacId;
            private string computer_name { get; } = Environment.MachineName;
            private string computer_username { get; } = Environment.UserName;
            private string net_version { get; } = Environment.Version.ToString();
            private string license_version { get; } = "4";
            public double suggestedprice { get; set; }
            public bool voted { get; set; }
            public bool willpay { get; set; }
            public string email { get; set; }

            public FormUrlEncodedContent GetUrlEncodedContent()
            {
                Dictionary<string, string> parameters = new Dictionary<string, string>
                {
                    {"test", test.ToString()},
                    {"mac_id", this.mac_id},
                    {"fingerprint", this.fingerprint},
                    {"computer_name", this.computer_name},
                    {"computer_username", this.computer_username},
                    {"net_version", this.net_version},
                    {"product_name", this.product_name},
                    {"product_version", this.product_version},
                    {"license_version", this.license_version},
                    {"username", this.username},
                    {"password", this.password}
                };


                return new FormUrlEncodedContent(parameters);
            }

            public FormUrlEncodedContent GetUrlEncodedContentVote()
            {
                Dictionary<string, string> parameters = new Dictionary<string, string>
                {
                    {"test", test.ToString()},
                    {"mac_id", this.mac_id},
                    {"fingerprint", this.fingerprint},
                    {"computer_name", this.computer_name},
                    {"computer_username", this.computer_username},
                    {"net_version", this.net_version},
                    {"product_name", this.product_name},
                    {"product_version", this.product_version},
                    {"license_version", this.license_version},
                    {"suggestedprice", this.suggestedprice.ToString(CultureInfo.InvariantCulture)},
                    {"voted", (this.voted == true) ? 1+"" : 0+""},
                    {"willpay", (this.willpay == true) ? 1+"" : 0+""},
                    {"email", this.email},
                    {"username", this.username},
                    {"password", this.password}
                };


                return new FormUrlEncodedContent(parameters);
            }
        }
    }
}
