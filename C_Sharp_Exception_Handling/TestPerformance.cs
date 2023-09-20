using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Exception_Handling
{
    public class TestPerformance
    {
        public void CheckPerformance()
        {
            const int Iteration = 10000000;
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            // switch

            for(int i = 0; i < Iteration; i++)
            {
                TestSwitch(5);
            }

            stopwatch.Stop();
            Console.WriteLine($"Switch statement time: {stopwatch.ElapsedMilliseconds} ms");

            stopwatch.Restart();

            stopwatch.Start();

            for (int i = 0; i < Iteration; i++)
            {
                TestIfElse(5);
            }

            stopwatch.Stop();
            Console.WriteLine($"If-Else statement time: {stopwatch.ElapsedMilliseconds} ms");
        }


        public void TestSwitch(int number)
        {
            switch(number) { 
            case 0:break;
            case 1:break;
            
            case 2:break;
            case 3:break;
            case 4:break;
                    default: break; 
            }
        }

        public void TestIfElse(int number)
        {
            if (number == 0)
            {

            }
            else if (number == 1) { }
            else if (number == 2) { }
            else if (number == 3) { }
            else if (number == 4) { }
            else { }

        }
    }
}
