using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextVerified
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            populate();
        }
        public static string tokenkey = null;
        public bool smsvalue = true;
        

        private void getBalance_Click(object sender, EventArgs e)
        {
            tokenkey = Program.Base64Encode(apiKey.Text + ":" + apiSecret.Text);
            string token = TextverifiedAPI.DoAuth("https://www.textverified.com/api/Authentication", tokenkey);
            dynamic response = TextverifiedAPI.DoPost("https://www.textverified.com/api/Users", token, "GET");
            outputBox.Text = "Balance is: " + response.credit_balance;
        }

        private void populate()
        {
            if (File.Exists("API.json"))
            {
                dynamic apiinfo = ApiKey.ReadJson();
                apiKey.Text = apiinfo[0].apikey.ToString();
                apiSecret.Text = apiinfo[0].apisecret.ToString();
            }
            else
            {
                MessageBox.Show("API.json created, Please edit and rerun the bot.");
                ApiKey.WriteJson();
                Environment.Exit(0);
            }

        }

        private void smsMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            tokenkey = Program.Base64Encode(apiKey.Text + ":" + apiSecret.Text);
            #pragma warning disable CS0252 // Possible unintended reference comparison; left hand side needs cast
            if (smsMode.SelectedItem == "Redeem")
            #pragma warning restore CS0252 // Possible unintended reference comparison; left hand side needs cast
            {
                smsvalue = true;
            }
            else
            {
                smsvalue = false;
            }
        }

        private void getNumber_Click(object sender, EventArgs e)
        {
            if (tokenkey != null)
            {
                string token = TextverifiedAPI.DoAuth("https://www.textverified.com/api/Authentication", tokenkey);
                //49 MSR
                //47 MS
                if (smsvalue == true)
                {
                    dynamic response = TextverifiedAPI.DoNumber("https://www.textverified.com/api/Verifications", token, "49");
                    Clipboard.SetText(response.number.ToString());
                    outputBox.Text=("Number is: " + response.number + Environment.NewLine);
                    string id = response.id;
                    do
                    {
                        Task.Delay(1200);
                        response = TextverifiedAPI.DoPost("https://www.textverified.com/api/Verifications/" + id, token, "GET");
                    } while (response.sms == "");
                    outputBox.AppendText(response.sms.ToString());
                }
                else{
                    dynamic response = TextverifiedAPI.DoNumber("https://www.textverified.com/api/Verifications", token, "47");
                    Clipboard.SetText(response.number.ToString());
                    outputBox.Text = ("Number is: " + response.number + Environment.NewLine);
                    string id = response.id;
                    do
                    {
                        Task.Delay(1200);
                        response = TextverifiedAPI.DoPost("https://www.textverified.com/api/Verifications/" + id, token, "GET");
                    } while (response.sms == "");
                    outputBox.AppendText(response.sms.ToString());
                }
            }
        }
    }
}
