using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace C_Sharp_Function_and_Methods
{
    public class NameToUpper
    {
        public void nametoUpper()
        {
            string takeInput = null;
            Console.WriteLine("Please type your name: ");
            takeInput = Console.ReadLine();
            int trypass = 0;
            while (Int32.TryParse(takeInput, out trypass))
            {
                Console.WriteLine("Please enter a string value");
                takeInput = Console.ReadLine();


            }

            string MyNameUpperCase = null;

            if (!string.IsNullOrEmpty(takeInput))
            {
                MyNameUpperCase = takeInput.ToUpper();
                Console.WriteLine($"Your converted name to upper is {MyNameUpperCase}");
            }
            else
            {
                Console.WriteLine("You have a empty string");
            }





        }

    }
}
