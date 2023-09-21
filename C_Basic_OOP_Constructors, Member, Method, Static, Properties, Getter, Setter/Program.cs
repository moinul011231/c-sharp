 namespace C_Basic_OOP_Constructors__Member__Method__Static__Properties__Getter__Setter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car Bmw = new Car();
            Car Audi = new Car();

            Bmw.Name = "Bmw";
            Console.WriteLine(Bmw.Name);
            //Bmw.SetCarName("BMW_Rockes");
            //Console.WriteLine(Bmw.GetCarName());

            Bmw.start();
            Audi.start();

            //Audi.start();
            //Bmw.Speed();
            //Audi.Speed();
            //Bmw.CarDetails();  
            //Audi.CarDetails();

            //Bmw.color = Color.Red;
            //Console.WriteLine(Bmw.color);

            //int BMW = Car.price;
            //BMW = 4;
            //Console.WriteLine(BMW);

            //Bmw.Start();
            //Bmw.Speed();
            //Audi.Start();
            //Audi.Speed();

        }
    }
}