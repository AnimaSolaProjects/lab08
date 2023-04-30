using System;
using System.Diagnostics;


namespace lab08
{
    public class Options
    {
        
        public void opt()
        {
            StackTrace s = new StackTrace();
            var pref = s.GetFrame(1);
            var meth = pref.GetMethod();
            Console.WriteLine($"opportunity of {meth.ReflectedType.Name}");
        }
    }
    #region ex1
    interface IAnimal { void PrintName(); }

    interface Icanfly { void Fly(); }

    interface Icanrun { void Run(); }


    
    public class Bird : IAnimal, Icanfly
    {
        public void Fly()
        {
            Console.WriteLine("Can fly");
        }

        public void PrintName()
        {
            var pn = new Options();
            pn.opt();
        }
    }
    public class Horse : IAnimal, Icanrun
    {
        public void PrintName()
        {
            var pn = new Options();
            pn.opt();
        }

        public void Run()
        {
            Console.WriteLine("Can run");
        }
    }
    public class Pegasus : Icanrun, Icanfly, IAnimal
    {
        public void Fly()
        {
            Console.WriteLine("Can fly");
        }

        public void PrintName()
        {

            Console.WriteLine("");
        }

        public void Run()
        {
            Console.WriteLine("Can run");
        }
    }
    #endregion


    #region main
    public class transport
    {
        public float price {get; set;}
        public float speed { get; set;}
        public int year { get; set;}

        public transport(float _price, float _speed, int _year)
        {
            price = _price;
            speed = _speed;
            year = _year;
        }
        public virtual void output() { }
    }
    public class plane : transport
    {
        public float hight { get; set;}
        public int numofpassengers { get; set; }

        
        public plane(float _price, float _speed, int _year, float _hight, int _passengernum) 
            : base( _price, _speed, _year )
        {
            hight = _hight;
            numofpassengers = _passengernum;
        }
        //public bool Find(plane plane)
        //{
        //    if (plane.year < 5)
        //    {

        //    }
        //}
        public override void output()
        {
            Console.WriteLine($"{this.price}, {this.hight}, {this.speed}, {this.year}");
        }
    }
    public class car : transport
    {
        public car(float _price, float _speed, int _year) 
            : base ( _price, _speed, _year)
        {
            price = _price;
            speed = _speed;
            year = _year;
        }
        public override void output()
        {
            Console.WriteLine($"{this.price}, {this.speed}, {this.year}");
        }
    }
    public class ship : transport
    {
        public int numofpassengers { get; set; }
        public string port { get; set; }
        public ship(float _price, float _speed, int _year, int _passengernum, string port)
            : base(_price, _speed, _year)
        {
            this.numofpassengers = _passengernum;
            this.port = port;
        }
        public override void output()
        {
            Console.WriteLine($"{this.price}, {this.numofpassengers}, {this.speed}, {this.year}");
        }
    }
    #endregion main

    public class Program
    {
        static void Main(string[] args)
        {

            //Bird bird = new Bird();
            //bird.PrintName();
            //bird.Fly();
            //Horse horse = new Horse();
            //horse.PrintName();
            //horse.Run();
            //Pegasus pegasus = new Pegasus();
            //pegasus.PrintName();
            //pegasus.Run();
            //pegasus.Fly();





            //float price = float.Parse(Console.ReadLine());
            //float speed = float.Parse(Console.ReadLine());
            //float hight = float.Parse(Console.ReadLine());
            //int year = int.Parse(Console.ReadLine());
            //int passengernum = int.Parse(Console.ReadLine());
            //transport transport = new transport(5, 6, 9);
            
            plane plane = new plane(1, 2, 3, 4, 5);
            plane plane1 = new plane(6, 7, 8, 9, 10);
            Console.Clear();
            //Console.WriteLine("PLANE");
            //plane.output();
            //float carprice = float.Parse(Console.ReadLine());
            //float carspeed = float.Parse(Console.ReadLine());
            //int caryear = int.Parse(Console.ReadLine());
            //car car = new car(carprice, carspeed, caryear);

            Console.WriteLine("plane 1:");
            plane.output();
            Console.WriteLine("plane 2:");
            plane1.output();
        }
    }
}