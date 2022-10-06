using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp6
{
    [Serializable]
    public class User
    {
        public string Name { get; set; }
        string PhoneNumber { get; set; }
        string Adress { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int PaidMoney { get; set; }

        public User(string name, string phoneNumber, string adress, string email, string password)
        {
            Name = name;
            PhoneNumber = phoneNumber;
            Adress = adress;
            Email = email;
            Password = password;
            PaidMoney = 0;
        }
    }
}
