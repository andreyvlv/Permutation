using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PermutationTest
{
    class Permute
    {       
        public static List<string> GetPermutation(string str)
        {
            var permutationResult = new List<string>();
            PermutationAlgorithm(str.Length - 1, str.ToCharArray(), permutationResult);
            permutationResult.Sort();
            return permutationResult;
        }

        static void PermutationAlgorithm(int n, char[] str, List<string> permutationResult)
        {
            if(n == 0)
            {                
                permutationResult.Add(new string(str));
            }
            else
            {
                for (int i = 0; i <= n; i++)
                {
                    PermutationAlgorithm(n - 1, str, permutationResult);
                    Swap(str, n % 2 == 0 ? i : 0, n);
                }
            }
        }

        static void Swap(char[]str, int i, int j)
        {
            var temp = str[i];
            str[i] = str[j];
            str[j] = temp;
        }
    }
}
