using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEasy;

namespace LoginTest
{
    public class License
    {
        public static LicenseUpdateManager LicenseUpdateManager1;

        public static async Task<bool> CheckLicense(string username, string password)
        {
            LicenseUpdateManager1 = new LicenseUpdateManager("http://license.botoverwatch.com/licensepay.php",
                "Simple Pixel Clicker", "1.0.0.0");
            LicenseUpdateManager1.username = username;
            LicenseUpdateManager1.password = password;

            await LicenseCheck();
            await UpdateCheck();

            return true;
        }

        static async Task<bool> LicenseCheck()
        {
            Debug.Write("license check!");
            var goodLicense = await LicenseUpdateManager1.CheckLicense();
            if (!goodLicense)
            {
                Console.WriteLine("BAD LICENSE!!!");
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("GOOD LICENSE!!!");
            }

            return true;
        }

        static async Task<bool> UpdateCheck()
        {
            Console.WriteLine("update check!");
            Console.WriteLine(LicenseUpdateManager1?.RemoteVersionResponse?.ToString());

            if (LicenseUpdateManager1 != null && LicenseUpdateManager1.UpdateAvaliable)
            {
                if (!await LicenseUpdateManager1.Update())
                {
                    Console.WriteLine(("Failed to update!" + "\n"));
                }
                else
                {
                    Console.WriteLine(("Updated!" + "\n"));
                    Process.Start(Application.ExecutablePath);
                }

                Debug.WriteLine(("No Update!" + "\n"));
            }

            return true;
        }
    }
}