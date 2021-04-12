using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace E_Wallet_Alpha.Models
{
    public class Transaction
    {

        public Transaction()
        {
            ID = new Guid();
        }

        [Required]
        public Guid ID { get; set; }

        [Required]
        [MaxLength(200)]
        public string Receiver { get; set; }

        [Required]
        public int AmountOfMoney { get; set; }

        [Required]
        public DateTime Date { get; set; }

        [Required]
        public bool DidIGetMoney { get; set; }
        [Required]
        public Guid UserID { get; set; }

        public override string ToString()
        {
            return DidIGetMoney ? $"{Receiver} uploaded money" : $"I paid to {Receiver}.";
        }
    }   
}
