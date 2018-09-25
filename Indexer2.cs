using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Indexer2
    {
        static void Main(string[] args)
        {
            Indexer1 id1 = new Indexer1(101, "Bhuvan", "Tirumala", "AP", 500000.00);
            Console.WriteLine("Eno " + id1[0]);
            Console.WriteLine("Ename " + id1[1]);
            Console.WriteLine("EAddress " + id1[2]);
            Console.WriteLine("ELocation " + id1[3]);
            Console.WriteLine("ESalary " + id1[4]);
            Console.Read();

        }
    }
}
