using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace C_Basic_OOP_Constructors__Member__Method__Static__Properties__Getter__Setter
{
    public enum Color
    {
        Red,
        Green,
        Blue,
        Yellow
    }
    internal class Car
    {
        private Color _color = default;
        private string _name = "Audi";
        private string _brand = "Audi-1";
        private DateTime _year;
        private int? _speed=null;

        public static int price;

        public string Name { get; set; } = "audi";


        //Defult constractor
        public Car()
        {
            Console.WriteLine($"{Name} has created ");
        }

        // Partial Constarctor

        public Car(Color color, string name)
        {
            _color = color;
            _name = name;   
        }


        //Full Constractor

        public Car(Color color, string name, string brand, DateTime year,int speed)
        {
            _color = color;
            _name = name;
            _brand = brand;
            _year = year;
            _speed = speed;
        }

        //public void SetCarName(string Name)
        //{
        //    _name = Name;
        //}

        //public string GetCarName() {
        //    return _name;
        //}


        public void start()
        {
            Console.WriteLine($"{Name} has started... ");
        }



        public void Speed ()
        {
            Console.WriteLine($"{_name} Speed is {_speed} km/h"); 
        }

        public void CarDetails()
        {
            Console.WriteLine($"{_name} is on {_speed}, it was manufactured in {_year}. The model of the car is {_brand} and the color is {_color}");
        }

    }


    
}
