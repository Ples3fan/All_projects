using Forsage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Forsage
{
    class Car
    {
        public delegate void Start();
        public delegate void Message();
        public event Message Display; 
        public int X { get; set; }

        public int Y { get; set; }

        public ConsoleColor Color { get; set; }
        public Car() { }

        public Car(ConsoleColor color,int x, int y)
        {
            Color = color;
            X = x;
            Y = y;
        }
        public bool condition { get; set; } = true;

        public int Speed(Random rnd, int r1, int r2)
        {
            int speed;
            return speed = rnd.Next(r1, r2 + 1);
        }

        public void Winner(string name)
        {

            Console.WriteLine($"{name} arrived");
        }

        public void Go(string name, int speed)
        {
            int distance = 0;
            Display += () => Winner(name);
            for (int i = 0; i < 110; i += 10, distance += 10)
            {
                Thread.Sleep(speed);
                if (distance == 100)
                    Display();
            }
        }

        public void Show()
        {
            Console.ForegroundColor = Color;
            Console.SetCursorPosition(X, Y);
            Console.WriteLine(@"     //:::::\\");
            Console.SetCursorPosition(X, Y + 1);
            Console.WriteLine(@" //############\\");
            Console.SetCursorPosition(X, Y + 2);
            Console.WriteLine(@"//### @ ##### @ #\\");
        }

        public void move(int step)
        {
            string sL = "";
            for (int i = 0; i < step; i++)
            {
                X++;
                if (new Random().Next(0, 300) == 13)
                {
                    Console.SetCursorPosition(X, Y);
                    Console.ForegroundColor = Color;
                    for (int j = 0; j < X; j++)
                        sL += ' ';
                    Console.Write($" _I\\__\n{sL}/X---x'");
                    condition = false;
                }
                else
                    Console.WriteLine(this);
            }
        }

    }

}


    class Program
    {
        static int console_width = 150;
        static int console_hight = 35;
    static int moves(Car[] cars)
    {
        var rnd = new Random();

        while (true)
        {
            int cnt_crash = 0;
            for (int i = 0; i < cars.Length; i++)
            {

                if (cars[i].X < console_width - 11)
                {
                    Thread.Sleep(50 / cars.Length);
                    if (cars[i].condition)
                        cars[i].move(rnd.Next(0, 2));
                    else
                        cnt_crash++;
                    if (cars.Length == cnt_crash)
                        return -1;
                }
                else
                {
                    return i;
                }

            }
        }
    }
    static void Main(string[] args)
        {
        Random random = new Random();
        int stavka = -1;
        int win = -1;
        int persons = -1;
        int y = 10;

        Console.SetWindowSize(console_width, console_hight);
        Console.WriteLine("Количество автомобилей?");
        persons = int.Parse(Console.ReadLine());
        Console.WriteLine("Ставка на машину номер: ");
        stavka = int.Parse(Console.ReadLine());
        Console.Clear();

        List<ConsoleColor> list = new List<ConsoleColor>

            {
                ConsoleColor.Red,
                ConsoleColor.Green,
                ConsoleColor.Yellow,
                ConsoleColor.White,
                ConsoleColor.Blue,
                ConsoleColor.Cyan,
                ConsoleColor.Magenta
            };
        List<Car> cars = new List<Car>();
        for (int i = 0; i < persons; i++)
        {
            cars.Add(new Car(list[i],1,y));
            cars[i].Show();
            y += 5;
        }
        for (int j = 0; j < 10; j++)
        {
            for (int i = 0; i < persons; i++)
            {
                cars[i].X += random.Next(5, 20);
            }
            Thread.Sleep(200);
            Console.Clear();
            foreach (Car car in cars)
            {
                car.Show();
            }
        }

        Console.ReadKey();
        }
    }

