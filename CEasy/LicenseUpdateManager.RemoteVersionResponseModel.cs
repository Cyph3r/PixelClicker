using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEasy
{
    public partial class LicenseUpdateManager
    {
        public class RemoteVersionResponseModel
        {
            public bool success { get; set; }
            public int test_result { get; set; }
            public string test_version { get; set; }
            public string message { get; set; }
            public string license_version { get; set; }
            public bool update_needed { get; set; }
            public string update_url { get; set; }
            public string file_hash { get; set; }
            public string note { get; set; }
            public string username { get; set; }
            public string permissions { get; set; }
            public string created { get; set; }
            public string expires { get; set; }
            public string updated { get; set; }
            public bool voted { get; set; }

            public override string ToString()
            {
                return $"success: {success}, test_result: {test_result}, test_version: {test_version}, message: {message}, license_version: {license_version}, update_needed: {update_needed}, update_url: {update_url}, file_hash: {file_hash}, note: {note}, username: {username}, permissions: {permissions}, created: {created}, expires: {expires}, updated: {updated}, voted: {voted}";
            }
        }
    }
}
