namespace C_Sharp_Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var testPerformance = new TestPerformance();
            testPerformance.CheckPerformance();
            //int number1 = 95;
            //int number2 = 4;
            //int addition = number1 + number2;
            //int multipllication = number1 * number2;
            //int division = number1/ number2;
            //Console.WriteLine($"Addition : {addition} Multiplication: {multipllication} division: {division}");

            //var num1 = 4;
            //var num2 = 5;
            //var num3 = 6;
            //var num4 = 7;
            //var num5 = 8;

            //Console.WriteLine(num1 + num2*(num3/num4)/num5);

            //// Unary Operators
            //int x = 5;
            //int y = -x;
            //int z = ++x;
            //Console.WriteLine($"Y = {y}  Z = {z}");

            //int a = 10;
            //int b = 20;
            //Console.WriteLine(a>b);
            //Console.WriteLine(a<b);
            //Console.WriteLine(a <= b);
            //Console.WriteLine(a <= b);
            //Console.WriteLine(a == b);
            //Console.WriteLine(a != b);


            ////Bitwise Operator
            //int c = 10;
            //int d = 8;
            //int resultAndBitwise = c & d;

            //Console.WriteLine("result {0}",resultAndBitwise);

            //string myName = "Moinul";
            //string OtherName = "Islam";

            //Console.WriteLine(myName == OtherName || myName != OtherName);

            // TRY - CATCH - FINALLY

            //int x=5; int y = 0;
            //int division = x / y;
            //Console.WriteLine(division);

            //try { Console.WriteLine("Enter first Number: ");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Enter Second Number: ");
            //    int num2 = int.Parse(Console.ReadLine());

            //    int result = num1 / num2;
            //    Console.WriteLine($"Result: {result}");


            //}
            //catch (DivideByZeroException ex) 
            //{
            //    Console.WriteLine($"Error: Division by zero is not allowed. {ex.Message }");
            //}

            //finally { Console.WriteLine("Done!"); }


            //IF- else

            //int num = 1;
            //if (num > 0)
            //{
            //    Console.WriteLine("Positive");
            //    if(num%2 == 0)
            //    {
            //        Console.WriteLine("Even");

            //    }
            //    else { Console.WriteLine("odd"); }
            //}
            //else
            //{
            //    Console.WriteLine("Negative");
            //}

            //switch (num)
            //{
            //    case 0: 
            //        Console.WriteLine("Number is 0");
            //        break;
            //    case 1:
            //        Console.WriteLine("Number is 1");
            //        break;

            //    default: Console.WriteLine();
            //        break;


            //}



            Console.ReadKey();  
        }
    }
}