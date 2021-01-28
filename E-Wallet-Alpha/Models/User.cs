using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Wallet_Alpha.Models
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Balance { get; set; }
    }
}
