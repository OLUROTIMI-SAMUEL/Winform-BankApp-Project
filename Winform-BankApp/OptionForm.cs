using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsWEEK4Assignment
{
    public partial class OptionForm : Form
    {
        private object text;

        public OptionForm()
        {

            InitializeComponent();
        }
        public string userEmail;
        public OptionForm(string UserEmail)
        {
            userEmail = UserEmail;
            InitializeComponent();
        }

        
        //public OptionForm(string AccountNumber)
        //{
        //    userEmail = AccountNumber;
        //    InitializeComponent();
        //}

        public OptionForm(object text)
        {
            this.text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DepositForm regDeposit = new DepositForm(userEmail);
            regDeposit.Show();
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            WithdrawForm regWithdraw = new WithdrawForm();
            regWithdraw.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TransferForm regTranfer = new TransferForm();
            regTranfer.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          AccountBalance regBalance = new AccountBalance();
            regBalance.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            StatementOfAccountForm regStatement = new StatementOfAccountForm();
            regStatement.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LoginForm regLogin = new LoginForm();
            regLogin.Show(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OptionForm_Load(object sender, EventArgs e)
        {
            var path = @"C:\Users\SAMUEL OLUROTIMI\source\repos\WinFormsWEEK4Assignment\WinFormsWEEK4Assignment\bin\Debug\net6.0-windows\LekeCustomers.Json";
            var customer = File.ReadAllText(path);
            var result = JsonConvert.DeserializeObject<JsonFileModel>(customer);        

            var loggedin_user = result.Users.FirstOrDefault(x => x.Email == userEmail);
            label1.Text = ($"Hey {loggedin_user.FirstName.ToUpper()}, Welocme to Leke Bank");

        }
    }
}
