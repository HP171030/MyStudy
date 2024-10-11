using System;

namespace MyStudy
{
    public class List<T>
    {
        T [] values;
        int count;
        int capacity;


        public List( int defaultCapacity = 4 )
        {
            capacity = defaultCapacity;
            values = new T [capacity];
            count = 0;
        }

        public T Add( T value )
        {
            if ( count > capacity )
            {
                Resize();
            }
            return values [count++] = value;

        }
        public T Get( int index )
        {
            if ( index >= count || index < 0 )
            {
                throw new IndexOutOfRangeException("OutRange");
            }
            return values [index];
        }
        void Resize()
        {
            capacity *= 2;
            T [] newValues = new T [capacity];
            Array.Copy(values, newValues, count);
            values = newValues;
        }
    }
}



