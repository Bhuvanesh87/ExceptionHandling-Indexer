using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ConsoleApp1
{
    class Exception1
    {
        public void Program1()
        {
            try
            {
                try
                {
                    Console.WriteLine("Enter First Number");
                    int Fn = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Second Number");
                    int Sn = Convert.ToInt32(Console.ReadLine());
                    int Result = Fn / Sn;
                    Console.WriteLine("The result is : " + Result);
                }
                catch (Exception ex)
                {
                    string filepath = @"F:\FileIo\abc6.txt";
                    if (File.Exists(filepath))
                    {
                        StreamWriter sw = new StreamWriter(filepath);
                        sw.WriteLine(ex.GetType().Name);
                        sw.WriteLine("--------------");
                        sw.WriteLine(ex.StackTrace);
                        sw.WriteLine("----------------");
                        sw.WriteLine(ex.Message);
                        sw.WriteLine("----------------");
                        sw.Close();
                        Console.WriteLine("There is a problem,please try later");
                    }
                    else
                    {
                        throw new FileNotFoundException(filepath + " is not present at " , ex);
                    }
                }
            }
            catch (Exception ex1)
            {
                Console.WriteLine("The Outer Exception is : " + ex1.GetType().Name);
                if(ex1.InnerException != null)
                Console.WriteLine("The inner Exception is : " + ex1.InnerException.GetType().Name);
            }
            
        }
    }
}
