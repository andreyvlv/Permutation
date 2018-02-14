using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationTest
{
    class GenericPermute
    {
        public static List<List<T>> GetPermutation<T>(List<T> array)
        {
            var permutationResult = new List<List<T>>();
            PermutationAlgorithm(array.Count - 1, array, permutationResult);
            return permutationResult;
        }

        public static void PermutationAlgorithm<T>(int n, List<T> array, List<List<T>> list)
        {
            if (n == 0)
            {
                var temp = new List<T>();
                foreach (var item in array)                
                    temp.Add(item);                              
                list.Add(temp);
            }
            else
            {
                for (int i = 0; i <= n; i++)
                {
                    PermutationAlgorithm(n - 1, array, list);
                    Swap(array, n % 2 == 0 ? i : 0, n);
                }
            }
        }

        static void Swap<T>(List<T> str, int i, int j)
        {
            var temp = str[i];
            str[i] = str[j];
            str[j] = temp;
        }
    }
}
