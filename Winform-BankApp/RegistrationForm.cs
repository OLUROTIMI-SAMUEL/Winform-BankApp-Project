using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsWEEK4Assignment
{
    public partial class RegistrationForm : Form
    {
        StartForm startupPage = new StartForm();
        static string firstName = "";
        static string lastName = "";
        static string cardNumber = "";
        static string Email = "";
        static string accountype = "";
        static double balance;
        static string password = "";

        //public static List<Customer> customer = new List<Customer>();
       
        public RegistrationForm()
        {
            InitializeComponent();
        }


        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            firstName = FirstNameTextBox.Text;
            lastName = SecondNameTextBox.Text;
            //ln = SecondNameTextBox.Text;
            accountype = AccountTypeTextBox.Text;
            password = PassWordTextBox.Text ;
            Email = EmailTextBox.Text ;
            cardNumber ="";
            balance = 0 ;

            try
            {
                //string path = @"C:\Users\SAMUEL OLUROTIMI\source\repos\WinFormsWEEK4Assignment\WinFormsWEEK4Assignment\bin\Debug\net6.0-windows\LekeCustomers.Json";

                var customers = File.ReadAllText(@"LekeCustomers.Json");

                var customerClass = new CustomerClass(firstName, lastName, cardNumber, password, balance, Email, accountype);

                // List<CustomerClass> result = JsonConvert.DeserializeObject<List<CustomerClass>>(customers);
                var result = JsonConvert.DeserializeObject<JsonFileModel>(customers);

                if (result == null)
                {
                    result = new JsonFileModel();
                }
                CustomerClass getUser = null;

                foreach (var user in result.Users)
                {
                    if (user != null && user.Email == EmailTextBox.Text)
                    {
                        getUser = user;
                        break;
                    }

                }
                if (getUser != null)
                {
                    MessageBox.Show("Email already Exist");
                }
                else
                {

                    result.Users.Add(customerClass);

                    var json = JsonConvert.SerializeObject(result);
                    var fileinfo = new FileInfo(@"LekeCustomers.Json");
                    using (StreamWriter users = new StreamWriter(fileinfo.Open(FileMode.Truncate)))
                    {
                        users.WriteLine(json);
                    }

                    MessageBox.Show($"Dear {firstName.ToUpper()}, Your Registration is Successful...");
                    //startupPage.Show();

                    LoginForm lg = new LoginForm();
                    lg.Show();
                }


            }
            catch (Exception)
            {
                throw;
            }
        }

         
        private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AccountTypeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void SecondNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SecondNameTextBox_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
