using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SplitStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Solution("abc"));
            foreach (string s in Solution("abcdef"))
                Console.WriteLine(s);
            Console.ReadKey();
        }

        //public static string[] Solution2(string str)
        //{
        //    return Regex.Matches(str + "_", @"\w{2}").Select(x => x.Value).ToArray();
        //}

        public static string[] Solution3(string str)
        {
            if (str.Length % 2 != 0) str += "_";
            var result = new string[str.Length / 2];
            for (int i = 0; i < result.Length; i++)
                result[i] = str.Substring(i * 2, 2);
            return result;
        }

        public static string[] Solution2(string str)
        {
            str = (str.Length % 2 == 0) ? str : str + "_";
            return
             Enumerable
              .Range(0, str.Length / 2)
              .Select(i => str.Substring(2 * i, 2))
              .ToArray();
        }

        public static string[] Solution1(string str)
        {
            if (str.Length % 2 == 1)
                str += "_";

            List<string> list = new List<string>();
            for (int i = 0; i < str.Length; i += 2)
            {
                list.Add(str[i].ToString() + str[i + 1]);
            }

            return list.ToArray();
        }

        public static string[] Solution(string str)
        {
            string[] result = null;
            var b = str.ToCharArray();
            string empty = "";
            string type = "_";
            if (str.Length % 2 != 0)
            {               
                for (int i = 0; i < b.Length; i++)
                {
                    if (i % 2 == 0 & i!=0)
                    {
                        empty += "*" + b[i];
                        
                    }
                    else empty+=b[i];
                }
                empty += type;
                var a = empty.Split('*');
                result = a;
            }

            if (str.Length % 2 == 0)
            {
                for (int i = 0; i < b.Length; i++)
                {
                    if (i % 2 == 0 & i != 0)
                    {
                        empty += "*" + b[i];

                    }
                    else empty += b[i];
                }
                var a = empty.Split('*');
                result = a;
            }

            return result;
        }
    }
}
