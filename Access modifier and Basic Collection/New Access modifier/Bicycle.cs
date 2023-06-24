using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Access_modifier
{
    public class Bicycle : SellBicycles
    {
        public int Wheels { get; set; }

        public void StartBicycle() 
        {
            Console.WriteLine("bicycle started");
        
        }

        public void AttachedWheel()
        {
            Console.WriteLine($"You have attached {Wheels} wheel");
        }
    }
}
