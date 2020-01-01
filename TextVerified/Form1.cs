using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
                    MessageBox.Show("Number is: " + response.number);
                    string id = response.id;
                    do
                    {
                        Thread.Sleep(4000);
                        response = TextverifiedAPI.DoPost("https://www.textverified.com/api/Verifications/" + id, token, "GET");
                    } while (response.sms == "");
                    outputBox.Text = response.sms;
                }
                else{
                    dynamic response = TextverifiedAPI.DoNumber("https://www.textverified.com/api/Verifications", token, "47");
                    MessageBox.Show("Number is: " + response.number);
                    string id = response.id;
                    do
                    {
                        Thread.Sleep(4000);
                        response = TextverifiedAPI.DoPost("https://www.textverified.com/api/Verifications/" + id, token, "GET");
                    } while (response.sms == "");
                    outputBox.Text = response.sms;
                }
            }
        }
    }
}
