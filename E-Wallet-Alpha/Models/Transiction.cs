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
        public string ToWhom { get; set; }

        [Required]
        public int AmountOfMoney { get; set; }

        public override string ToString()
        {
            return $"Paid {AmountOfMoney} HUF to {ToWhom}.";
        }
    }   
}
