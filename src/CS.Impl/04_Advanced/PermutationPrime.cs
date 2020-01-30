using System;
using System.Collections.Generic;
using CS.Impl._02_Intermediate;

namespace CS.Impl._04_Advanced
{
    public class PermutationPrime
    {
        public int[] GetPermutationPrimes(int upperBound)
        {

            Recursion recusion = new Recursion();
            List<int> result = new List<int>(); 

            foreach (int val in recusion.GetNaturalNumbers(upperBound))
            {
                List<int> ints = new List<int>();
                string valStr = val.ToString();

                permute(valStr, 0, valStr.Length - 1, ints);

                Boolean isPermutationPrime = true;

                foreach (int elem in ints)
                {
                    isPermutationPrime = isPermutationPrime && recusion.IsPrime(elem);
                }

                if (isPermutationPrime)
                {
                    result.Add(val);
                }
            }

            return result.ToArray();
        }

        private void permute(string str, int l, int r, List<int> list)
        {
            if (l == r)
            {
                if (!list.Contains(Int16.Parse(str)))
                {
                    list.Add(Int16.Parse(str));
                }
            }
            else
            {
                for (int i = l; i <= r; i++)
                {
                    str = swap(str, l, i);
                    permute(str, l + 1, r, list);
                    str = swap(str, l, i);
                }
            }
        }


        private string swap(String a, int i, int j)
        {
            char temp;
            char[] charArray = a.ToCharArray();
            temp = charArray[i];
            charArray[i] = charArray[j];
            charArray[j] = temp;
            return new string(charArray);
        }

    }
}
