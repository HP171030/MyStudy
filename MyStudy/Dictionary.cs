using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStudy
{
    public class Dictionary<TKey, TValue>
    {
        List<KeyValuePair<TKey, TValue>> [] table;

        public Dictionary( int size )
        {
            table = new List<KeyValuePair<TKey, TValue>> [size];
            for ( int i = 0; i < size; i++ )
            {
                table [i] = new List<KeyValuePair<TKey, TValue>>();
            }
        }

    }

    class Program
    {
        static void Main( string [] args )
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(5);

            Console.WriteLine(list.Get(0));
        }
    }
}
