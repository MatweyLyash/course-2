using Lab_3;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_3
{
    public class Set<T> : IEnumerable<T>
    {
        private T[] items;
        public int currentSize { get; private set; }
        private int capacity;
        public Set(int capacity, params T[] items)
        {
            this.items = new T[capacity];
            int iter = 0;
            foreach (var item in items)
            {
                this.items[iter++] = item;
            }
            currentSize = items.Length;
            this.capacity = capacity;

        }

        public Set(int capacity)
        {
            this.currentSize = 0;
            this.items = new T[capacity];
            this.capacity = capacity;

        }

        public void Add(T item)
        {
            if (currentSize == capacity)
            {
                Array.Resize(ref items, currentSize + 1);
                capacity++;
            }
            items[currentSize] = item;//но в итоге элемент смогли добавить
            currentSize++;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in items)
            {
                yield return item;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public T this[int index]
        {
            get => items[index];
            set => items[index] = value;
        }
        public static Set<T> operator ++(Set<T> obj)
        {
            Random rnd = new Random();
            obj.Add((T)(object)rnd.Next());
            return obj;
        }
        public static Set<T> operator +(Set<T> obj1, Set<T> obj2)
        {
            
            foreach (T item in obj2)
            {
                if (!obj1.isFind(item))
                {
                    obj1.Add(item);
                }
            }
            return obj1;
        }
        public void Print()
        {
            foreach (var item in items)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }
        public bool isFind(T item)
        {
            foreach (var item2 in items)
            {
                if (item.Equals(item2)) return true;
            }
            return false;
        }
        public static bool operator <=(Set<T> obj3, Set<T> obj4)
        {
            foreach (T item in obj4)
            {
                if (!obj3.isFind(item))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool operator >=(Set<T> obj3, Set<T> obj4)
        {
            foreach (T item in obj3)
            {
                if (!obj4.isFind(item))
                {
                    return false;
                }
            }
            return true;
        }
        public static implicit operator int(Set<T> obj1)
        {
            return obj1.items.Length;

        }
        public static T operator %(Set<T> obj1, int index)
        {
            return obj1.items[--index];
        }
        public void Sorted(Set<T>obj1)
        {
            T[] sorted= new T[obj1.capacity];
            int i = 0;
            foreach (T item in items)
            {
                sorted[i] = item;
                i++;
            }
            Array.Sort(sorted);
            for (int j = 0; j < sorted.Length; j++)
            {
                Console.WriteLine($"{sorted[j]}" );
            }
            return;
        }
    }
}
