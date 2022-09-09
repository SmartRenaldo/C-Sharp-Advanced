using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_ToString
{
    class Program
    {
        static void Main(string[] args)
        {
            double d = 1.2345678;
            int i = 12345678;

            string s1 = d.ToString();
            Console.WriteLine("1.2345678.ToString() = " + s1);

            string s2 = d.ToString("#.#######");
            Console.WriteLine("1.2345678.ToString(\"#.#######\") = " + s2);

            string s3 = d.ToString("#.######0");
            Console.WriteLine("1.2345678.ToString(\"#.######0\") = " + s3);

            string s4 = d.ToString("#.#######0");
            Console.WriteLine("1.2345678.ToString(\"#.#######0\") = " + s4);

            string s5 = d.ToString("#.######8");
            Console.WriteLine("1.2345678.ToString(\"#.######8\") = " + s5);

            string s6 = 0.ToString("0.00");
            Console.WriteLine("0.ToString(\"0.00\") = " + s6);

            string s7 = i.ToString(",#");
            Console.WriteLine("12345678.ToString(\",#\") = " + s7);

            string s8 = i.ToString("#,#");
            Console.WriteLine("12345678.ToString(\"#,#\") = " + s8);

            string s9 = i.ToString("##,#");
            Console.WriteLine("12345678.ToString(\"##,#\") = " + s9);

            string s10 = i.ToString("###,#");
            Console.WriteLine("12345678.ToString(\"###,#\") = " + s10);

            string s11 = i.ToString("####,#");
            Console.WriteLine("12345678.ToString(\"####,#\") = " + s11);
        }
    }
}
