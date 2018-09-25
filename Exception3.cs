using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Exception3
    {
        public void Program3()
        {
            int[] array1 = { 1, 2 ,3,4,5,6,7};
            int[] array2 = { 3, 4,5,6,7,8,9,10,11,12,13,15 };

            try
            {
                array1.CopyTo(array2,-1);
                Console.WriteLine("array1 elements are ");
                for (int i=0;i<array1.Length;i++)
                {
                    Console.Write(array1[i]+" ");
                }
                Console.WriteLine("array2 elements are ");
                for (int i = 0; i < array2.Length; i++)
                {
                    Console.Write(array2[i] + " ");
                }
                
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Error: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("This statement is always executed.");
            }







        }
    }
}
