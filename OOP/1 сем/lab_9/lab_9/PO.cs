using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab_9
{

    public class Software
    {
        public string Name { get; set; }
        public Software(string name)
        {
            Name = name;
        }
    }

    public class PO<T> : IList<T>
    {
        T[] arr;
        private int Length { get; set; }
        public PO()
        {
            arr = new T[10];
            Length = 0;
        }
        public PO(int capacity)
        {
            arr = new T[capacity];
            Length = 0;
        }

        public T this[int index] { get => arr[index]; set => arr[index] = value; }


        public int Count => Length;

        public bool IsReadOnly => false;

        public void Add(T item)
        {
            arr[Length] = item;
            Length++;

        }

        public void Clear()
        {
            Array.Clear(arr, 0, Length);
            Length = 0;
        }

        public bool Contains(T item)
        {
            if (Array.IndexOf(arr, item) == -1) return false;
            return true;
        }

        public void CopyTo(T[] array, int arrayIndex)
        {
            int j = 0;
            T[] otherMassive = new T[Length - arrayIndex];
            for (int i = arrayIndex; i < arr.Length; i++)
            {
                otherMassive[j++] = arr[i];
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            foreach (var item in arr)
            {
                yield return item;
            }
        }

        public int IndexOf(T item)
        {
            return Array.IndexOf(arr, item);
        }

        public void Insert(int index, T item)
        {
            arr[index] = item;//
        }

        public bool Remove(T item)
        {
            if (Array.IndexOf(arr, item) == -1) return false;
            int index = IndexOf(item);
            for (int i = index; i > arr.Length - index - 1; i--)
            {
                arr[i] = arr[i + 1];
            }
            int[] newarr = new int[arr.Length - 1];
            Array.Copy(arr, newarr, arr.Length - 1);
            return true;
        }

        public void RemoveAt(int index)
        {
            for (int i = index; i > arr.Length - index - 1; i--)
            {
                arr[i] = arr[i + 1];
            }
            int[] newarr = new int[arr.Length - 1];
            Array.Copy(arr, newarr, arr.Length - 1);

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator(); 
        }


    }
}
