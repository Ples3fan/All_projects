using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_3_Student_Pleskanev_
{
    class Student
    {
        Random random = new Random();
        public int[][] myArr = new int[3][];
            
        string firstName, lastName, group; 
        Student(string fName, string lName, string gr)
        {
            firstName = fName;
            lastName = lName;
            group = gr;
            myArr[0] = new int[4];
            myArr[1] = new int[6];
            myArr[2] = new int[3];
            for (int i=0 ; i < 4; i++)
            {
                myArr[0][i] = random.Next(5,12);
            }
            for (int i = 0; i < 6; i++)
            {
                myArr[1][i] = random.Next(5, 12);
            }
            for (int i = 0; i < 3; i++)
            {
                myArr[2][i] = random.Next(5, 12);
            }
        }
        public string getFNmae()
        {
            return firstName;
        }
        public string getLNmae()
        {
            return lastName;
        }
        public string getGroup()
        {
            return group;
        }
        public void changeMarks(int pr, int pos, int mark)
        {
            myArr[pr-1][pos-1] = mark;
        }
        public void showMarks(int pr)
        {
            int val = pr - 1;
            if (val == 0)
            {
                Console.Write("\tHistory: ");
                for (int i = 0; i < 4; i++)
                {
                    Console.Write(myArr[0][i]+" ");
                }
            }
            if (val == 1)
            {
                Console.Write("\n\tPhysik: ");
                for (int i = 0; i < 6; i++)
                {
                    Console.Write(myArr[1][i]+" ");
                }
            }
            if (val == 2)
            {
                Console.Write("\n\tMathematick: ");
                for (int i = 0; i < 3; i++)
                {
                    Console.Write(myArr[2][i]+" ");
                }
                Console.WriteLine("\n");
            }
            
        }
        public void showInfo()
        {
            Console.WriteLine($"\n Name: {this.getFNmae()} \n Last Name: {this.getLNmae()} \n Group: {this.getGroup()}");
            this.showMarks(1);
            this.showMarks(2);
            this.showMarks(3);
        }
        public void searchStudy(string Name,int predmet,int position,int mark)
        {
            if (Name == this.getFNmae())
            {
                this.changeMarks(predmet, position, mark);
                this.showMarks(predmet);
            }
            else
                return;
        }
        public void searchPredmet(string Name, int position)
        {
            if (Name == this.getFNmae())
            {
                int val = position - 1;
                if (val == 0)
                {
                    Console.Write("\tHistory: ");
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write(myArr[0][i] + " ");
                    }
                }
                if (val == 1)
                {
                    Console.Write("\n\tPhysik: ");
                    for (int i = 0; i < 6; i++)
                    {
                        Console.Write(myArr[1][i] + " ");
                    }
                }
                if (val == 2)
                {
                    Console.Write("\n\tMathematick: ");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.Write(myArr[2][i] + " ");
                    }
                    Console.WriteLine("\n");
                }
            }
            else
                return;
        }
        static void Main(string[] args)
        {
            
            
            
            Student num1 = new Student("Jimmy", "Button", "789TH1");
            Student num2 = new Student("Jully", "Ficha", "783TH2");
            Student num3 = new Student("Tom", "Clept", "289VH3");

            num1.showInfo();
            num2.showInfo();
            num3.showInfo();

            Console.WriteLine("Enter name of student: ");
            string tmp = Console.ReadLine();
            Console.WriteLine("Enter predmet for change: ");
            int predmet = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of mark for change: ");
            int position = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the new mark: ");
            int mark = Convert.ToInt32(Console.ReadLine());

            num1.searchStudy(tmp, predmet, position, mark);
            num2.searchStudy(tmp, predmet, position, mark);
            num3.searchStudy(tmp, predmet, position, mark);

            Console.WriteLine("\nEnter name of student: ");
            tmp = Console.ReadLine();
            Console.WriteLine("Enter the number of predmet(1 - History, 2 - Physik:, 3 - Mathematik): ");
            position = Convert.ToInt32(Console.ReadLine());

            num1.searchPredmet(tmp, position);
            num2.searchPredmet(tmp, position);
            num3.searchPredmet(tmp, position);


            Console.ReadKey();
        }
    }

}
