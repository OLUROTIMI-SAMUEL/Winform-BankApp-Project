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
using System.IO;

namespace WinFormsWEEK4Assignment
{
    public partial class LoginForm : Form
    {
        //public object AccountNumberLogin { get; private set; }
        //public object AccountnumberLogin { get; private set; }
        //public OptionForm OptionForm { get; private set; }
        //public object PasswordLogin { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            var path = @"C:\Users\SAMUEL OLUROTIMI\source\repos\WinFormsWEEK4Assignment\WinFormsWEEK4Assignment\bin\Debug\net6.0-windows\LekeCustomers.Json";
            var customer = File.ReadAllText(path);

            var result = JsonConvert.DeserializeObject<JsonFileModel>(customer);

            if (result.Users.Any(x => x.Email == AccountNumberText.Text && x.Password == PassWordText.Text))
            {
                //OptionForm = new OptionForm(AccountNumberText.Text);

                OptionForm optionForm = new OptionForm(AccountNumberText.Text);
                this.Hide();
                optionForm.Show();                
            }else
            {
                MessageBox.Show("Login Not Successful");
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartForm regStart = new StartForm();
            regStart.Show();

        }

    internal record struct NewStruct(object Item1, object Item2)
    {
        public static implicit operator (object, object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((object, object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }


    //var path = @"C:\Users\SAMUEL OLUROTIMI\source\repos\WinFormsWEEK4Assignment\WinFormsWEEK4Assignment\bin\Debug\net6.0-windows\LekeCustomers.json";
    //var customer = File.ReadAllText(path);

    //var result = JsonConvert.DeserializeObject<list<customer>>(customer);

}
}
