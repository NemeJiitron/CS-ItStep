using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project2.hm.HM_9
{
    internal class StringDelegates
    {
        public static void Run()
        {
            Func<string, int> vowels = (str) =>
            {
                int res = 0;
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
                foreach (char c in str)
                {
                    if (!char.IsWhiteSpace(c))
                    {
                        if (vowels.Contains(c))
                        {
                            res++;
                        }
                    }
                }
                return res;
            };

            Func<string, int> Consonants = (str) =>
            {
                int res = 0;
                char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O', 'U', 'Y' };
                foreach (char c in str)
                {
                    if (!char.IsWhiteSpace(c))
                    {
                        if (!vowels.Contains(c))
                        {
                            res++;
                        }
                    }
                }
                return res;
            };

            Func<string, int> Length = (str) =>
            {
                int res = 0;
                foreach (char c in str)
                {
                    if (!char.IsWhiteSpace(c))
                    {
                        res++;
                    }
                }
                return res;
            };
        }
    }
}

