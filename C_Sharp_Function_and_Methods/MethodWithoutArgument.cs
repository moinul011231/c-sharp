using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Function_and_Methods
{
    public class MethodWithoutArgument
    {
        public int number1 { get; set; } = 1;
        public int number2 { get; set; } = 3;
        const int number3 = 4;
        const int number4 = 5;

        public int AddNumberWithoutPara()
        { 
            return this.number1 + this.number2;
        }

        public int AddNumberWithConst()
        {
            return number3 + number4;
        }
    }
}
