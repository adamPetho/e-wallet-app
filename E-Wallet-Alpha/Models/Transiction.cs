using System;

namespace E_Wallet_Alpha.Models
{
    public class Transiction
    {

        public Transiction()
        {
            ID = new Guid();
        }

        public Guid ID { get; set; }
        public string ToWhom { get; set; }

        public int AmountOfMoney { get; set; }

        public override string ToString()
        {
            return $"Paid {AmountOfMoney} HUF to {ToWhom}.";
        }
    }   
}
