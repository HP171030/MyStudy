using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStudy
{
    public class Dictionary<TKey, TValue>
    {
        public List<KeyValuePair<TKey, TValue>> [] tables;



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
