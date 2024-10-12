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
            
        }

        public void Test2( string [] args )
        {
            Console.Clear();
            string [] s = Console.ReadLine().Split(' ');

            int a = int.Parse(s [0]);
            int b = int.Parse(s [1]);

            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
        }

        public void Test( string [] args )
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

        public void Test4( string [] args )
        {
            string str = Console.ReadLine();

            string result = ChangeCase(str);
            Console.WriteLine(result);


            Console.WriteLine("!@#$%^&*(\\'\"<>?:;");               // 특수문자

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
        public void Test5( string [] args )
        {
            string [] s;

            Console.Clear();
            s = Console.ReadLine().Split(' ');

            int a = int.Parse(s [0]);
            int b = int.Parse(s [1]);
            int c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");
        }

        public void Test6( string [] args )
        {
            string s;

            Console.Clear();
            s = Console.ReadLine();

            char [] chars = s.ToCharArray();
            for ( int i = 0; i < s.Length; i++ )
            {
                Console.WriteLine(chars [i]);
            }
        }

        public void Test7()
        {
            String s;

            Console.Clear();
            s = Console.ReadLine();

            int a = Int32.Parse(s);

            if ( a % 2 == 0 )
            {
                Console.WriteLine($"{a} is even");
            }
            else
            {
                Console.WriteLine($"{a} is odd");
            }
        }
        public string Test8( string my_string, string overwrite_string, int s )
        {
            char [] chars = my_string.ToCharArray();


            for ( int i = 0; i < overwrite_string.Length; i++ )
            {
                chars [s + i] = overwrite_string [i];
            }

            return new string(chars);
        }

        public string Test9(string str1,string str2 )
        {
            char [] chars = str1.ToCharArray();
            char [] chars2 = str2.ToCharArray();

            char [] resultChar = new char [chars.Length + chars2.Length];

            for ( int i = 0; i < chars.Length; i++)
            {
                resultChar [2 * i] = chars [i];
            }
            for(int i = 0; i < chars2.Length; i++ )
            {
                resultChar [2 * i + 1] = chars2 [i];
            }

            return new string(resultChar);
        }

        public string Test10( string [] arr )
        {
            string answer = String.Join("", arr);

            return answer;
        }
        public string Test11( string my_string, int k )
        {
            string answer = "";
            for(int i = 0; i < k; i++ )
            {
                answer += my_string; // my_string을 answer에 이어 붙임
            }

             answer = String.Concat(Enumerable.Repeat(my_string,k));
            return answer;
        }
        public int Test12( int a, int b )
        {
            // a와 b를 문자열로 변환하여 결합
            string ab = $"{a}{b}"; // a ⊕ b
            string ba = $"{b}{a}"; // b ⊕ a

            // 두 문자열을 정수로 변환하여 비교
            int resultAb = int.Parse(ab);
            int resultBa = int.Parse(ba);

            // 더 큰 값을 반환, 같으면 ab를 반환
            return resultAb >= resultBa ? resultAb : resultBa;
        }
        public int Test13( int a, int b )
        {
            int answer = 0;
            string ab = $"{a}{b}";
            int abValue = int.Parse(ab);
            int cross = 2 * a * b;

            answer = abValue >= cross ? abValue : cross;
            if ( abValue == cross )
                answer = abValue;

            return answer;
        }
    }



//    source :  https://school.programmers.co.kr/learn/challenges
}


