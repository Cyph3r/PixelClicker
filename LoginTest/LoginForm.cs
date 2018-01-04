using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginTest
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();

            this.hwid.Text = CEasy.CEasy.FingerPrint;
        }

        public LoginForm(string username, string password, bool remember)
        {
            InitializeComponent();

            this.username.Text = username;
            this.password.Text = password;
            this.remember.Checked = remember;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            //var str = await Login();
            //
            //Int32 unixTimestamp = (Int32)(DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1))).TotalSeconds;
            //string nearest10ThOfASecond = unixTimestamp - (unixTimestamp%30) + "9354892144548565456541";
            //var temp = DecryptRJ256(Convert.FromBase64String(str), "lkirwf897+22#bbtrm8814z5qq=498j5", nearest10ThOfASecond);
            try
            {
                 await License.CheckLicense(username.Text, password.Text);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }
        public async Task<string> Login()
        {
            using (var client = new HttpClient())
            {
                var httprequest1 = new HttpRequestMessage
                {
                    Method = HttpMethod.Post,
                    RequestUri = new Uri("http://botoverwatch.com/forum/ucp.php?mode=login"),
                    Content = GetUrlEncodedContent()
                };

                await client.SendAsync(httprequest1);

                var httprequest2 = new HttpRequestMessage
                {
                    Method = HttpMethod.Get,
                    RequestUri = new Uri("http://botoverwatch.com/forum/userbridge.php")
                };

                var httpRespose = await client.SendAsync(httprequest2);

                var str = await httpRespose.Content.ReadAsStringAsync();

                return str;
            }
        }
        public FormUrlEncodedContent GetUrlEncodedContent()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>
                {
                    {"username", username.Text},
                    {"password", password.Text},
                    {"login", "Login"}
                };


            return new FormUrlEncodedContent(parameters);
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
