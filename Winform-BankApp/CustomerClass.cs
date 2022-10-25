using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsWEEK4Assignment
{
    public class CustomerClass
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CardNumber { get; set; }
        public string Password { get; set; }
        public double Balance { get; set; }
        public string Email { get; set; }
        public string AccountType { get; set; }

        public CustomerClass(string FirstName, string LastName, string CardNumber, string Password, double Balance, string Email, string AccountType)

        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.CardNumber = CardNumber;
            this.Password = Password;
            this.Balance = Balance;
            this.Email = Email;
            this.AccountType = AccountType;

        }

    }
}
