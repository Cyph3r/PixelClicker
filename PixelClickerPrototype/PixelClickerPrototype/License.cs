using System;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;
using CEasy;

namespace PixelClickerPrototype
{
    public class License
    {
        public static LicenseUpdateManager LicenseUpdateManager1;

        public static async void CheckLicense()
        {
            LicenseUpdateManager1 = new LicenseUpdateManager("http://license.botoverwatch.com/license.php",
                "Simple Pixel Clicker", "1.0.0.0");
            await LicenseCheck();
            await UpdateCheck();
        }

        static async Task<bool> LicenseCheck()
        {
            Debug.Write("license check!");
            var goodLicense = await LicenseUpdateManager1.CheckLicense();
            if (!goodLicense)
            {
                Debug.WriteLine("BAD LICENSE!!!");
                Environment.Exit(0);
            }
            else
            {
                Debug.WriteLine("GOOD LICENSE!!!");
            }

            return true;
        }

        static async Task<bool> UpdateCheck()
        {
            Debug.WriteLine("update check!");
            Debug.WriteLine(LicenseUpdateManager1.RemoteVersionResponse.ToString());

            if (LicenseUpdateManager1.UpdateAvaliable)
            {
                if (!await LicenseUpdateManager1.Update())
                {
                    Debug.WriteLine(("Failed to update!" + "\n"));
                }
                else
                {
                    Debug.WriteLine(("Updated!" + "\n"));
                    Process.Start(Application.ExecutablePath);
                }

                Debug.WriteLine(("No Update!" + "\n"));
            }

            return true;
        }
    }
}