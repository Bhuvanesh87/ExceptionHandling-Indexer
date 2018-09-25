using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Exception2
    {
        public  void Program2()
        {
            FileStream fs = null;
            try
            {
                
                fs = new FileStream(@"C:\temp\data.txt", FileMode.Open);
                StreamReader sr = new StreamReader(fs);
                string line;

                //A value is read from the file and output to the console.
                line = sr.ReadLine();
                Console.WriteLine(line);
            }
            catch (FileNotFoundException e)
            {
               // Console.WriteLine("[Data File Missing]"+ e.Message);
                throw new FileNotFoundException(@"[data.txt not in c:\temp directory]", e.StackTrace);
            } 
            finally
            {
                if (fs != null)
                    fs.Close();
            }
        }
    }
}
