using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KioskProject
{
    public class CartItem
    {
        public string Name { get; set; }
        public string Spiciness { get; set; }
        public bool IsUpsize { get; set; }
        public int Quantity { get; set; }
        public int TotalPrice { get; set; }

        public override string ToString()
        {
            string upsizeText = IsUpsize ? "곱빼기-" : "";
            return $"{Name}-{upsizeText}{Spiciness}-{Quantity}개 : {TotalPrice}원";
        }
    }
}
