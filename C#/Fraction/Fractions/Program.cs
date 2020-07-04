using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fractions
{
    class Fraction
    {
        public int n 
        { get; set; } 
        public int z 
        { get; set; } 
        public Fraction(){}
        public Fraction(int x, int y)
        {
            this.n = x;
            this.z = y;
        }
        public override string ToString()
        {
            return $"{this.n} / {this.z}";
        }
        public static Fraction operator +(Fraction x1, Fraction x2)
        {
            Fraction temp = new Fraction();
            int znamen=0;
            int chislit = 0;
            znamen = x1.z * x2.z;
            chislit = (x1.n * x2.z) + (x2.n * x1.z);
            temp.n = chislit;
            temp.z = znamen;
            return temp;
        }
        public static Fraction operator +(Fraction x1, double x2)
        {
            int znam = 1;
            while (x2 > (int)x2)
            {
                x2 *= 10;
                znam *= 10;
            }

            Fraction f = new Fraction((int)x2, znam);
            return x1 + f;

        }
        public static Fraction operator -(Fraction x1, Fraction x2)
        {
            Fraction temp = new Fraction();
            int znamen = 0;
            int chislit = 0;
            znamen = x1.z * x2.z;
            chislit = (x1.n * x2.z) - (x2.n * x1.z);
            temp.n = chislit;
            temp.z = znamen;
            return temp;
        }
        public static Fraction operator *(Fraction x1,Fraction x2)
        {
            Fraction temp = new Fraction();
            int znamen = 0;
            int chislit = 0;
            znamen = x1.z * x2.z;
            chislit = x1.n * x2.n;
            temp.n = chislit;
            temp.z = znamen;
            return temp;
        }
        public static Fraction operator *(Fraction x1, int x2)
        {
            Fraction temp = new Fraction();
            int znamen = 0;
            int chislit = 0;
            chislit = x1.n * x2;
            temp.n = chislit;
            temp.z = x1.z;
            return temp;
        }
        public static Fraction operator *(int x1, Fraction x2)
        {
            Fraction temp = new Fraction();
            int chislit = 0;
            chislit = x1 * x2.n;
            temp.n = chislit;
            temp.z = x2.z;
            return temp;
        }
        public static Fraction operator /(Fraction x1, Fraction x2)
        {
            Fraction temp = new Fraction();
            int znamen = 0;
            int chislit = 0;
            znamen = x1.z * x2.n;
            chislit = x1.n * x2.z;
            temp.n = chislit;
            temp.z = znamen;
            return temp;
        }
        public static bool operator >(Fraction x1, Fraction x2)
        {
            int first = x1.n*x2.z;
            int second = x1.z*x2.n;
            return first > second;
        }
        public static bool operator <(Fraction x1, Fraction x2)
        {
            int first = x1.n * x2.z;
            int second = x1.z * x2.n;
            return first < second;
            
        }
        public static bool operator ==(Fraction x1, Fraction x2)
        {
            return x1.n == x2.n && x1.z == x2.z;
        }
        public static bool operator !=(Fraction x1, Fraction x2)
        {
            return x1.n != x2.n || x1.z != x2.z;
        }
        public static bool operator true(Fraction x1)
        {
            return x1.z > x1.n;
        }
        public static bool operator false(Fraction x1)
        {
            return x1.z < x1.n;
        }
        public void print() { Console.WriteLine(this.ToString()); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f = new Fraction(3, 4);
            f.print();
            int a = 10;
            Fraction f1 = f * a;
            f1.print();
            Fraction f2 = a * f;
            f2.print();
            double d = 1.5;
            Fraction f3 = f + d;
            f3.print();

            Console.ReadKey();
        }
    }
}
