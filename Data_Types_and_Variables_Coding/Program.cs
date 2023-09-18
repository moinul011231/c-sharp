using System.Drawing;

namespace Data_Types_and_Variables_Coding
{
    //public class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        //int x = 10;
    //        //int y = x;
    //        //x = 30;
    //        //Console.WriteLine("x "+x);
    //        //Console.WriteLine("y "+y);

    //        //int[] array1 = { 1, 2, 3 };
    //        //int[] array2 = array1;
    //        //Console.WriteLine("array1 " + array1[0]);
    //        //Console.WriteLine("array2 " + array2[0]);
    //        //array1[0] = 10;
    //        //Console.WriteLine("array1 " + array1[0]);
    //        //Console.WriteLine("array2 " + array2[0]);

    //        //int number1 = 25;
    //        //int number2 = 25;
    //        //int sum = number1 + number2;

    //        //Console.WriteLine("number1: {0} + number2: {1} = sum: {2}", number1, number2, sum);

    //        //float SinglePrecision = 1.2000002f;
    //        //double doublePrecision = 1.0000000000000000004545d;
    //        //decimal higherprecision = 1_000_0000_0000.21212m;


    //    }

    //}


    //public enum DayOfWeek
    //{
    //    Monday,
    //    Tuesday,
    //    Wednesday,
    //    Thursday,
    //    Friday,
    //    Saturday,
    //    Sunday
    //}


    //public class DaysOfWeek
    //{
    //    static void Main(string[] args)
    //    {
    //        DayOfWeek today = DayOfWeek.Sunday;
    //        Console.WriteLine("Today is " + today);

    //        if (today == DayOfWeek.Sunday || today == DayOfWeek.Saturday)
    //        {
    //            Console.WriteLine("It is weekend");
    //        }
    //        else
    //        {
    //            Console.WriteLine("It is weekday");
    //        }
    //    }
    //}

    //struct Point
    //{
    //    public int X;
    //    public int Y;
    //}

    //public class Pointer
    //{
    //    static void Main(string[] args)
    //    {
    //        Point p = new Point();
    //        p.X = 10;
    //        p.Y = 20;
    //        Console.WriteLine("X is : {0} \nY is : {1}",p.X,p.Y);
    //    }
    //}

    public class BuildTupple
    {
        static void Main(string[] args)
        {
            Tuple<int,string> person = new Tuple<int,string>(25, "Fariha");
            Console.WriteLine("Age: {0}\nName: {1}",person.Item1,person.Item2);


        }
    }
}
