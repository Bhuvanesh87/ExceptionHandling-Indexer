using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Exception4
    {
        public void Program4()
        {
            try
            {
                StreamReader sr = File.OpenText("data.txt");
                Console.WriteLine("The first line of this file is {0}", sr.ReadLine());
                sr.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred: '{0}'", e.StackTrace);
            }
        }
    }
}
