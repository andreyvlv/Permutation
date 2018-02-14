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
            string str = "abcd";
            List<string> permutations = Permute.GetPermutation(str);
            Print(permutations);
            Console.ReadKey();
        }

        static void Print<T>(IEnumerable<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
