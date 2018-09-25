using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Indexer1
    {
            int Eno;
            string Ename, EAddress, ELocation;
            double ESalary;

            public Indexer1(int Eno,string Ename,string EAddress,string ELocation,double ESalary)
            {
                this.Eno = Eno;
                this.Ename = Ename;
                this.EAddress = EAddress;
                this.ELocation = ELocation;
                this.ESalary = ESalary;
            }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return Eno;
                else if (index == 1)
                    return Ename;
                else if (index == 2)
                    return EAddress;
                else if (index == 3)
                    return ELocation;
                else if (index == 4)
                    return ESalary;
                else
                    return null;               
                        
            }
        }

                
    }
}
