using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationTest
{
    class Program
    {
        static void Main(string[] args)
        {                       
            var permutaionIntArray = GenericPermute.GetPermutation(new[] { 1, 2, 4 }.ToList());
            var permutationString = GenericPermute.GetPermutation("abcd".ToList());
            Print(permutaionIntArray);
            Console.WriteLine();
            Print(permutationString);
            Console.ReadKey();
        }

        static void Print<T>(IEnumerable<IEnumerable<T>> list)
        {
            foreach (var array in list)
            {
                foreach (var item in array)
                    Console.Write(item);
                Console.WriteLine();
            }                        
        }
    }
}
