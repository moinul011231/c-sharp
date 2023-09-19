namespace C_sharp_Data_Types_and_Variables_String_Manipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.BackgroundColor = ConsoleColor.White;
            // Console.Write("hello world");
            // Console.WriteLine("Hello, World!");
            // Console.Clear();
            // Console.ReadKey();



            //type casting
            //double MyDoubleAge = 13.57;
            //int myIntage = (int)MyDoubleAge;
            //Console.WriteLine(myIntage);

            //string myStringAge = "18";
            //int myAge = Int32.Parse(myStringAge);
            //Console.WriteLine(myAge);

            //int num1 = 4; int num2 = 5;
            //Console.WriteLine(num1+num2);
            //string number1 = "4";
            //string number2 = "5";
            //Console.WriteLine(number1+number2);

            //int numInt1 = Int32.Parse(number1);
            //int numInt2 = Int32.Parse(number2);
            //Console.WriteLine(numInt1+numInt2);

            string myName = "Moinul";

            Console.WriteLine($"Hello, {myName}");
            Console.WriteLine(@"c:\ar\c_sharp");
            Console.WriteLine(myName.IndexOf("i"));


        }
    }
}