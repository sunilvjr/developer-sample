using System;

namespace DeveloperSample.Algorithms
{
    public static class Algorithms
    {
        public static int GetFactorial(int n) 
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }
            else
            {
                return n * GetFactorial(n - 1);
            }
        }

        public static string FormatSeparators(params string[] items) {
           
            if (items == null || items.Length == 0)
            {
                return string.Empty;
            }
            string separator = ",";
            string result = string.Join(separator, items);
            return result;
        }
    }
}