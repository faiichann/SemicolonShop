using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SemicolonShop.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string UFirstName { get; set; }
        public string ULastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Birthday { get; set; }
        public string Date { get; set; }

    }
}
