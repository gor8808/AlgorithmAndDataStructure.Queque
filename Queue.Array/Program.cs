using System;
using System.Collections;
using System.Collections.Generic;

namespace Queue.Array
{
    class Queue<T> : IEnumerable<T>
    {
        T[] _item = new T[0];

        int _size = 0;
        int _head = 0;
        int _tail = 0;

        public void Enqueue(T item) 
        {
            //_head = (int)item;
            T[] newArray = new T[_item.Length == 0 ? 4 : _item.Length * 2];
            _item.CopyTo(newArray, 0);
           
        }
        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

    }
}
