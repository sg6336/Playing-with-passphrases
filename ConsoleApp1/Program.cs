using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayPass.playPass("BORN IN 2015!", 1);
        }
    }

    public class PlayPass
    {
        public static string playPass(string s, int n)
        {
            string strUpper = s.ToUpper();

            string strShift = ShiftLetter(strUpper, n);
            string strReplace = ReplaceDigit(strShift, 9);
            string strDowncase = DowncaseOdd(strReplace);
            string strReverse = Reverse(strDowncase);

            return strReverse;
        }

        static string ShiftLetter(string str, int n)
        {
            string result = "";
            char shiftC;
            int min = 'A';
            int max = 'Z';
            //str = str.ToUpper();
            foreach (char c in str)
            {
                if (Char.IsLetter(c) == true)
                {
                    if (c + n > max)
                    {
                        int move = (c + n) % max - 1;
                        shiftC = (char) (min + move);
                    }
                    else
                    {
                        shiftC = (char) (c + n);
                    }
                    result += shiftC;
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        static string ReplaceDigit(string str, int d = 9)
        {
            string result = "";
            foreach (char c in str)
            {
                if (Char.IsDigit(c) == true)
                {
                    int dig = Convert.ToInt32(c.ToString());
                    if (d == 9)
                    {
                        dig = d - dig;
                    }
                    else
                    {
                        throw new Exception("It`s not 9");
                    }
                    result += Convert.ToString(dig);
                }
                else
                {
                    result += c;
                }
            }
            return result;
        }

        static string DowncaseOdd(string str)
        {
            string result = "";
            bool flagOdd = false;
            foreach (char c in str)
            {
                if (Char.IsLetter(c) == true)
                {
                    if (flagOdd == true)
                    {
                        result += Char.ToLower(c);
                    }                                   
                    else
                    {
                        result += c;
                    }                   
                }
                else
                {
                    result += c;
                }
                flagOdd = !flagOdd;
            }
            return result;
        }

        static string Reverse(string str)
        {
            string result = "";

            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            result = new string(charArray);

            return result;
        }
    }
}