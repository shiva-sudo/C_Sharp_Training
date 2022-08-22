using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Application
{
    public class DictionaryExercise
    {

        public static string Practice(int i)
        {
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                {0,"Zero" },
                {1,"One " },
                {2,"Two" },
                {3,"Three" },
                {4,"Four" },
                {5,"Five" }
            };
            if (dic.ContainsKey(i))
            {
                return dic[i];
            }
            else
            {
                return "nope";
            }
        }
        static void Main(string[] args)
        {
            Practice(3);
            Console.ReadLine();
        }
    }
}
