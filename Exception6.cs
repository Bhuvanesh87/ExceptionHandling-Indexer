using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Exception6
    {
        public void Program6()
        {
            unchecked
            {
                int val = byte.MaxValue;
                Console.WriteLine(val + 2);
            }

        }
    }
}
