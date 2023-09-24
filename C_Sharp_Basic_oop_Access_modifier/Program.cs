using New_Acess_Modifier;

namespace C_Sharp_Basic_oop_Access_modifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            BaseClass.count = 0;
            BiCycle biCycle = new BiCycle();

            biCycle.wheels = 2;
            biCycle.StartBicycle();
            biCycle.AttachedWheel();
            biCycle.GenerateInvoice();

        }
    }
}