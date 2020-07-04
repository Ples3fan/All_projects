using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Funny_Sky
{
    class Program
    {
        
        abstract class Basic
        {
            public abstract void Show();
        }
        delegate void Callback();
        class Dispatcher
        {
            public event Callback callbackEvent;
            public void Connections()
            {
                if (callbackEvent != null)
                {
                    callbackEvent.Invoke();
                }
            }
        }
        
        class Parashut: Basic
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Parashut() { }
            public Parashut(int x, int y)
            {
                X = x;
                Y = y;
            }
            public override void Show()
            {
                Console.SetCursorPosition(X, Y);
                Console.WriteLine(@" /\");
                Console.SetCursorPosition(X, Y + 1);
                Console.WriteLine(@"/  \");
                Console.SetCursorPosition(X, Y + 2);
                Console.WriteLine(@"____");
            }
        }
        class Sphere: Basic
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Sphere() { }
            public Sphere(int x, int y)
            {
                X = x;
                Y = y;
            }

            public override void Show()
            {
                Console.SetCursorPosition(X, Y);
                Console.WriteLine(@"   _");
                Console.SetCursorPosition(X, Y + 1);
                Console.WriteLine(@"  (x)");
                Console.SetCursorPosition(X, Y + 2);
                Console.WriteLine(@"((xxx))");
                Console.SetCursorPosition(X, Y + 3);
                Console.WriteLine(@"  \x/");
                Console.SetCursorPosition(X, Y + 4);
                Console.WriteLine(@"   x");
            }


        }
        static List<Basic> activeConnections;
        class Fireweerks : Basic
        {
            public int X { get; set; }
            public int Y { get; set; }
            public Fireweerks() { }
            public Fireweerks(int x, int y)
            {
                X = x;
                Y = y;
            }

            public override void Show()
            {
                Console.SetCursorPosition(X, Y);
                Console.WriteLine(@"  x");
                Console.SetCursorPosition(X, Y + 1);
                Console.WriteLine(@" xxx");
                Console.SetCursorPosition(X, Y + 2);
                Console.WriteLine(@"xxxxx");
                Console.SetCursorPosition(X, Y + 3);
                Console.WriteLine(@" xxx");
                Console.SetCursorPosition(X, Y + 4);
                Console.WriteLine(@"  x");
            }
        }
        static void Main(string[] args)
        {
            Random random = new Random();

            activeConnections = new List<Basic>();


            for (int i = 0; i < 10; i++)
            {
                activeConnections.Add(new Fireweerks(random.Next(2, 30), random.Next(2, 30)));
            }
            for (int i = 0; i < 10; i++)
            {
                activeConnections.Add(new Sphere(random.Next(2, 30), random.Next(2, 30)));
            }
            for (int i = 0; i < 10; i++)
            {
                activeConnections.Add(new Parashut(random.Next(2, 30), random.Next(2, 30)));
            }

            for (int i = 0; i < 30; i++)
            {
                Thread.Sleep(600);
                activeConnections[i].Show();
                Thread.Sleep(600);
                Console.Clear();
            }

            //Dispatcher dispatcher = new Dispatcher();
            //foreach (Basic connection in activeConnections)
            //{
                
            //    dispatcher.callbackEvent += connection.Show;
                
            //}
            //dispatcher.Connections();
            
            Console.ReadLine();
        }
        


    }
}

