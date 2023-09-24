using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_Acess_Modifier
{
    public class BiCycle: SellBicycle
    {
        public int wheels { get; set; }

        public void StartBicycle()
        {
            Console.WriteLine("Bicycle has started");
        }

        public void AttachedWheel()
        {
            Console.WriteLine($"You have attached {wheels} wheels");
        }

        public void GenerateInvoice()
        {
            var bicycle = new BiCycle();
            bicycle.SetPrice(100);
            bicycle.Amount = 2;
            bicycle.Invoice();
        }

    }
}
