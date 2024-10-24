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
    class Box
    {
        protected float width;
        protected float height;

        public Box SetWidth(float width )
        {
            this.width = width;
            return this;
        }
        public Box SetHeight(float height )
        {
            this.height = height;
            return this;
        }
    }

    class OutLinedBox : Box
    {
        protected float outlineWidth;
        public OutLinedBox SetOutlineWidth(float outlineWidth )
        {
            this.outlineWidth = outlineWidth;
            return this;
        }
    }

    class test
    {
      /*  OutLinedBox olBox1 = new OutLinedBox().SetOutlineWidth(2f)                     
            .SetWidth(10f);     //박스타입 리턴이라 안됨*/
    }
   /* class Program
    {
        static void Main( string [] args )
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(5);

            Console.WriteLine(list.Get(0));
        }
    }*/
}
