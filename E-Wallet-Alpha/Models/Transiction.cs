using System;
using System.ComponentModel.DataAnnotations;

namespace E_Wallet_Alpha.Models
{
    public class Transiction
    {

        public Transiction()
        {
            ID = new Guid();
        }

        [Required]
        public Guid ID { get; set; }

        [Required]
        [MaxLength(200)]
        public string ToOrFromSomeOne { get; set; }

        [Required]
        public int AmountOfMoney { get; set; }

        [Required]
        public bool DidIGetMoney { get; set; }

        public override string ToString()
        {
            return DidIGetMoney ? $"{ToOrFromSomeOne} paid me" : $"I paid to {ToOrFromSomeOne}.";
        }
    }   
}
