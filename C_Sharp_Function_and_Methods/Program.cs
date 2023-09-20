using System;
namespace C_Sharp_Function_and_Methods
{
    internal class HelloWorld
    {
        static void Main(string[] args)
        {
            var result = AddNumber(2, 2);
            Console.WriteLine(result);

            var sum = new MethodWithoutArgument();
            var result1 = sum.AddNumberWithoutPara();
            Console.WriteLine(result1);
            var result2 = sum.AddNumberWithConst();
            Console.WriteLine(result2);
            var Name = new NameToUpper();
            Name.nametoUpper();

        }

        static int AddNumber(int number1, int number2)
        {
            return number1 + number2;
        }
    }

   
}