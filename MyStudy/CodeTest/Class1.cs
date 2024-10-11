using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStudy.CodeTest
{
    public class Class1
    {
        public static void Main( string [] args )
        {
            string s = "str";

            Console.Clear();
            Console.WriteLine(s);
        }
    }


    public class Class2
    {
        public static void Main( string [] args )
        {
            Console.Clear();
            string [] s = Console.ReadLine().Split(' ');

            int a = int.Parse(s [0]);
            int b = int.Parse(s [1]);

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }
    }

    public class Class3
    {
        public static void Main( string [] args )
        {
            Console.Clear();
            string [] stringArray = Console.ReadLine().Split(' ');
            string s = stringArray [0];
            int n = int.Parse(stringArray [1]);
            for ( int i = 1; i <= n; i++ )
            {
                Console.Write(s);
            }
        }
    }

    public class Class4
    {
        public static void Main( string [] args )
        {
            string str = Console.ReadLine();

            string result = ChangeCase(str);
            Console.WriteLine(result);


            Console.WriteLine("!@#$%^&*(\\'\"<>?:;");               // 특수문자
        }

        static string ChangeCase( string str )
        {
            char [] chars = str.ToCharArray();

            for ( int i = 0; i < chars.Length; i++ )
            {
                if ( char.IsUpper(chars [i]) )
                {
                    chars [i] = char.ToLower(chars [i]);
                }
                else if ( char.IsLower(chars [i]) )
                {
                    chars [i] = char.ToUpper(chars [i]);
                }
            }
            return new string(chars);
        }



    }
}



source :  https://school.programmers.co.kr/learn/challenges