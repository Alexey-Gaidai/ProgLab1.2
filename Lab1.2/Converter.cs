using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1._2
{
    internal class Converter : IUseCases
    {
        private Dictionary<char, int> letters = new Dictionary<char, int>()
        {
            { 'A', 10 },
            { 'B', 11 },
            { 'C', 12 },
            { 'D', 13 },
            { 'E', 14 },
            { 'F', 15 }
        };
       
        public double convert(string number)
        {
            number = Reverse(number);
            double result = 0;
            if (isDouble(number) == true)
            {
                string[] splitted = number.Split('.');
                string lastPart = splitted[0];
                string firstPart = splitted[1];
                
                for (int i = 1; i < lastPart.Length+1; i++)
                {
                    if (letters.ContainsKey(lastPart[i-1]))
                    {
                        var n = letters[lastPart[i-1]];
                        result += n * Math.Pow(16, -i);
                    }
                    else
                    {
                        result += Convert.ToDouble(lastPart[i-1].ToString()) * Math.Pow(16, -i);
                    }
                }
                for (int i = 0; i < firstPart.Length; i++)
                {
                    if (letters.ContainsKey(firstPart[i]))
                    {
                        var n = letters[firstPart[i]];
                        result += n * Math.Pow(16, i);
                    }
                    else
                    {
                        result += Convert.ToDouble(firstPart[i].ToString()) * Math.Pow(16, i);
                    }
                }
            }
            else
            {

                for (int i = 0; i < number.Length; i++)
                {
                    if (letters.ContainsKey(number[i]))
                    {
                        var n = (int)letters[number[i]];
                        result += n * Math.Pow(16, i);
                    }
                    else
                    {
                        result += Convert.ToInt32(number[i].ToString()) * Math.Pow(16, i);
                    }
                }
            }
            return result;
        }

        private bool isDouble(string hex)
        {
            if (hex.Contains("."))
            {
                return true;
            }
            else return false;
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
