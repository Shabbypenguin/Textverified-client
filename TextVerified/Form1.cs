using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void getBalance_Click(object sender, EventArgs e)
        {
            string tokenkey = Program.Base64Encode(apiKey.Text + ":" + apiSecret.Text);
            Console.WriteLine(tokenkey);
            string token = TextverifiedAPI.DoAuth("https://www.textverified.com/api/Authentication", tokenkey);
            dynamic response = TextverifiedAPI.DoPost("https://www.textverified.com/api/Users", token, "GET");
            outputBox.Text = "Balance is: " + response.credit_balance;
        }
    }
}
