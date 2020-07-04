using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Figure
    {
        protected int X { get; set; }
        protected int Y { get; set; }

        protected string Name { get; set; }

        public Figure(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X: {X} Y: {Y}";
        }

        public virtual void Print()
        {
            Console.WriteLine($"Name: {Name}");
        }

        public abstract double Square();

        public abstract int Perimeter();
    }
    class Triangle : Figure
    {
        public int Z { get; set; }

        public int P { get; set; }

        public Triangle(int x, int y, int z) : base(x, y)
        {
            Z = z;
        }

        public override int Perimeter()
        {
            return P = X + Y + Z;
        }

        public override double Square()
        {
            return (double)Math.Sqrt((P / 2) * ((P / 2) - X) * ((P / 2) - Y) * ((P / 2) - Z));
        }

        public override void Print()
        {
            Console.WriteLine($"Треугольник");
        }
    }

    class Squared : Figure
    {
        public Squared(int x, int y) : base(x, y)
        {
        }

        public override int Perimeter()
        {
            return X * 4;
        }

        public override double Square()
        {
            return (double)Math.Pow(X, 2);
        }
        public override void Print()
        {
            Console.WriteLine($"Квадрат");
        }
    }

    class Rhombus : Figure
    {
        public int H { get; set; }
        public Rhombus(int x, int y, int h) : base(x, y)
        {
            H = h;
        }

        public override int Perimeter()
        {
            return X * 4;
        }

        public override double Square()
        {
            return (double)(X * H);
        }
        public override void Print()
        {
            Console.WriteLine($"Ромб");
        }
    }

    class Rectangle : Figure
    {
        public Rectangle(int x, int y) : base(x, y)
        {
        }

        public override int Perimeter()
        {
            return (X + Y) * 2;
        }

        public override double Square()
        {
            return (double)(X * Y);
        }
        public override void Print()
        {
            Console.WriteLine($"Прямоугольник");
        }
    }

    class Circle : Figure
    {
        private const double Pi = 3.14;

        public int R { get; set; }

        public Circle(int x, int y, int r) : base(x, y)
        {
            R = r;
        }

        public override int Perimeter()
        {
            return 2 * (int)Pi * R;
        }

        public override double Square()
        {
            return (double)(Pi * (double)Math.Pow(R, 2));
        }
        public override void Print()
        {
            Console.WriteLine($"Круг");
        }
    }

    public class Compound
    {
        static double generalSquare;

        Figure[] FigureArray;

        public Compound()
        {
            FigureArray = new Figure [0];
        }

        public double AddFigure(Figure geometricFigure)
        {
            Array.Resize(ref FigureArray, FigureArray.Length + 1);
            generalSquare += geometricFigure.Square();
            return generalSquare;
        }

        public void PrintgeneralSquare()
        {
            Console.WriteLine($"Площадь составной фигуры: {generalSquare}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Triangle(5, 7, 4);
            figure.Print();
            Console.WriteLine($"Периметр: {figure.Perimeter()} ");
            Console.WriteLine($"Площадь: {figure.Square()} ");

            Figure figure2 = new Squared(5, 5);
            figure2.Print();
            Console.WriteLine($"Периметр: {figure2.Perimeter()} ");
            Console.WriteLine($"Площадь: {figure2.Square()} ");

            Figure figure3 = new Rhombus(5, 5, 8);
            figure3.Print();
            Console.WriteLine($"Периметр: {figure3.Perimeter()} ");
            Console.WriteLine($"Площадь: {figure3.Square()} ");

            Figure figure4 = new Rectangle(5, 6);
            figure4.Print();
            Console.WriteLine($"Периметр: {figure4.Perimeter()} ");
            Console.WriteLine($"Площадь: {figure4.Square()} ");

            Figure figure5 = new Circle(5, 5, 10);
            figure5.Print();
            Console.WriteLine($"Периметр: {figure5.Perimeter()} ");
            Console.WriteLine($"Площадь: {figure5.Square()} ");
            Console.WriteLine("=============================");


            Compound f = new Compound();
            f.AddFigure(figure2);
            f.AddFigure(figure3);
            f.AddFigure(figure4);
            f.PrintgeneralSquare();


            Console.ReadKey();
        }
    }
}
