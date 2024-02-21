using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionsAndGenerics
{
    public class Generic<T> where T : struct
    {
        public T Message;

        //public int MEssage;
        //public float MEssage;


        public void GenericMethod(T Param1, T Param2)
        {
            Console.WriteLine($"Message: {Message}");
            Console.WriteLine($"Param1: {Param1}");
            Console.WriteLine($"Param2: {Param2}");
        }

        //public void GenericMethod(int Param1, int Param2)
        //{
        //    Console.WriteLine($"Message: {Message}");
        //    Console.WriteLine($"Param1: {Param1}");
        //    Console.WriteLine($"Param2: {Param2}");
        //}


        //public void GenericMethod(float Param1, float Param2)
        //{
        //    Console.WriteLine($"Message: {Message}");
        //    Console.WriteLine($"Param1: {Param1}");
        //    Console.WriteLine($"Param2: {Param2}");
        //}

    }
}
