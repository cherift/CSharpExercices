using System;
using System.Collections.Generic;

namespace CS.Impl._02_Intermediate
{
    public class Recursion
    {

        private List<int> res = new List<int> { };
        public IEnumerable<int> GetNaturalNumbers(int n)
        {
            if (n == 1)
            {
                this.res.Add(1);
                return this.res;
            }
            else
            {
                this.res.Add(n);
                return GetNaturalNumbers(n - 1);
            }
        }

        private IEnumerable<int> GetNaturalNumbers(List<int> naturalNumbers, int current, int max)
        {
            throw new NotImplementedException();
        }

        public int SumNaturalNumbers(int n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {
                return n + SumNaturalNumbers(n - 1);
            }
        }

        private int ComputeSum(int min, int current)
        {
            throw new NotImplementedException();
        }

        public bool IsPrime(int n)
        {
            return IsPrime(n, 2);
        }

        private bool IsPrime(int n, int current)
        {
            if (current == 1)
            {
                return true;
            }
            else
            {
                if (n % current == 0)
                    return false;
                else
                    return IsPrime(n, current - 1);
            }
        }

        public bool IsPalindrome(string text)
        {
            if (text.Length == 0 || text.Length == 1)
            {
                return true;
            }
            else
            {
                return (text[0] == text[text.Length - 1]) && IsPalindrome(text.Substring(1, text.Length - 2));
            }
        }
    }
}
