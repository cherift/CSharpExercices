using System;

namespace CS.Impl._01_Basic
{
    public class Sentence
    {
        public string Reverse(string sentence)
        {
            string result = "";

            String[] splited = sentence.Split(" ");

            foreach (string s in splited)
            {
                result = s + " " + result;
            }

            return result.Trim(); 
        }
    }
}
