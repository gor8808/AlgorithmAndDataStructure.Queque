using System;
using System.Collections;
using System.Collections.Generic;

namespace AlgorithmAndDataStructure.Queque
{
    public class Queue<T> : IEnumerable<T>
    {

        LinkedList<T> _items = new LinkedList<T>();
        public int Count { get => _items.Count; }
        public void Enqueue(T item)
        {
            _items.AddLast(item);
        }
        public T Dequeue()
        {
            if(_items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
            T item = _items.First.Value;
            _items.RemoveFirst();
            return item;
        }
        public T Peek()
        {
            if (_items.Count == 0)
            {
                throw new InvalidOperationException("The queue is empty");
            }
            return _items.First.Value;
        }
        public void Clear()
        {
            _items.Clear();
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
