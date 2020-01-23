using System;
using System.Collections.Generic;

namespace CS.Impl._04_Advanced
{
    public class PermutationPrime
    {
        public int[] GetPermutationPrimes(int upperBound)
        {
            throw new NotImplementedException();
        }

        public int GetDigitLength(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            else {
                return 1 + GetDigitLength((int) n / 10);
            }
        }

        public List<int> GetListADigit(List<int> digits,  int n) {
            if (n == 0) {
                return digits;
            }
            else {
                int pow = (int)Math.Pow(10, GetDigitLength(n));
                int dig = n / pow;
                digits.Add(dig);
                return GetListADigit(digits, n - (dig * pow));
            }
        }

        public List<int> GetPermutationsOfANumber(int n) {
            List<int> allDigits = new List<int>();
            List<int> result = new List<int>();

            GetListADigit(allDigits, n);
            

            return result;
        }
       

    }
}
