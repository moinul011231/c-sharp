using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Access_modifier
{
    internal class SellBicycles
    {
        protected int Price { get; set; }

        protected int Amount { get; set;}

        public void Invoice() 
        {
            Console.WriteLine($"Your total is {Price * Amount}");
        
        }
    }
}
