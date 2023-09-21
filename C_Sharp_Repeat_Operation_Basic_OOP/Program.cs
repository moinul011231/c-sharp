namespace C_Sharp_Repeat_Operation_Basic_OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int count =0; count<10; count++)
            {
                if (count == 3)
                {
                    Console.WriteLine("Skip at 3");
                    continue;

                }
                Console.WriteLine(count);
            }


            //while loop(Interger reversal)

            int number = 123456;
            int reverseNumber = 0;

            while(number != 0)
            {
                int remainder = number % 10;
                Console.WriteLine(remainder);
                reverseNumber = reverseNumber*10 + remainder;
                Console.WriteLine(reverseNumber);
                number /= 10;
            }

            //do while (fizzBuzz)

            int i = 1;
            do
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");

                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");

                }
                else
                {
                    Console.WriteLine(i);
                }
                i++;
            }
            while (i <= 100);
        }
    }
}