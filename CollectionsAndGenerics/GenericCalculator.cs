using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndGenerics
{
    public class GenericCalculator<T> where T : struct
    {
        public void Print(T t1, T t2)
        {
            Console.WriteLine(t1);
            Console.WriteLine(t2);
        }
    }
}
