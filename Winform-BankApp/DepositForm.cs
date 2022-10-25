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
    public partial class DepositForm : Form
    {
        public string userEmail;
        //private object showAcountBalance;
        //private object depositAmt;
        //private object showaccountBalance;

        public DepositForm(string accountNumber)
        {
            userEmail = accountNumber;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           string path = @"C:\Users\SAMUEL OLUROTIMI\source\repos\WinFormsWEEK4Assignment\WinFormsWEEK4Assignment\bin\Debug\net6.0-windows\LekeCustomers.Json";



            string customers = File.ReadAllText(path);
            List<CustomerClass> result = JsonConvert.DeserializeObject<List<CustomerClass>>(customers);
           
            double amount = double.Parse(textBoxes.Text);



            var LoggedinUser = result.FirstOrDefault(x => x.CardNumber == userEmail);

            LoggedinUser.Balance += amount;




            var resultJson = JsonConvert.SerializeObject(result);


            
            File.WriteAllText(path, resultJson);



           textBoxes.Text = "Your balance is" + LoggedinUser.Balance.ToString();



            MessageBox.Show($"New balance = {LoggedinUser.Balance}");
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {

        }

        private void textBoxes_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
