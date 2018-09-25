using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Exception5
    {
        public void Program5()
        {
            checked
            {
                int val = int.MaxValue;
                Console.WriteLine(val + 2);
            }

            //In checked context, arithmetic overflow raises an exception whereas, in an unchecked context, arithmetic overflow is ignored and result is truncated.
        }
    }
}
