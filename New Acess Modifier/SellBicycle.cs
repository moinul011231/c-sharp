using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Acess_Modifier
{
    public class SellBicycle
    {
        private int _price;
        protected int Amount { get; set; }

        protected void SetPrice(int price)
        {
            _price = price;
        }

        public void Invoice()
        {
            Console.WriteLine($"Your total price is {_price*Amount}");
        }
    }
}
