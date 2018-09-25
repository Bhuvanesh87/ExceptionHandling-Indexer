using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the program number to execute");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                        Exception1 ex1 = new Exception1();
                        ex1.Program1();
                        break;
                case 2:
                        Exception2 ex2 = new Exception2();
                        ex2.Program2();
                        break;
                case 3:
                        Exception3 ex3 = new Exception3();
                        ex3.Program3();
                        break;
                case 4:
                        Exception4 ex4 = new Exception4();
                        ex4.Program4();
                        break;
                case 5:
                        Exception5 ex5 = new Exception5();
                        ex5.Program5();
                        break;
                case 6:
                        Exception6 ex6 = new Exception6();
                        ex6.Program6();
                        break;
                case 7:
                    Exception7 ex7 = new Exception7();
                    ex7.Program7();
                    break;


            }
            Console.Read();
        }
    }
}
