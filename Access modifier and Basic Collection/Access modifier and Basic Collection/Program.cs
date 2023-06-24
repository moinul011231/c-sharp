using New_Access_modifier;

namespace Access_modifier_and_Basic_Collection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Bicycle bicycle = new Bicycle();

            bicycle.Wheels = 3;

            bicycle.AttachedWheel();
            bicycle.StartBicycle(); 

        }
    }
}