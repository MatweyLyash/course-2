using lab_3;
using Lab_3;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Lab_3
{
    public class CollectionType<T/*бесконеяное количнство параметров*/> : IEnumerable<T>, TInterface<T> //where T:
        /*unmanaged//не ссылочный тип, структура с ссылками в ней не прокатит, а в struct можно */
        //notnull// нельзя переадать 0
        //new()//публичный конструктор без параметров( должен быть реализован)
        //IEnumerator<T>//этот интерфейс и все его классы которые имплементируют
    {
        public List<T> items;
        public CollectionType(params T[] values)
        {
            items = new List<T>();
            foreach (var item in values)
            {
               
                items.Add(item);
            }
        }
        public void AddElement(T item)
        {
           items.Add(item);
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
        
        public  void Show()
        {
            foreach(T item in items)
            {
                Console.WriteLine(item);
            }
        }
        public void Add(T element)
        {
            AddElement(element);
        }
        public void Remove(T element)
        {
            items.Remove(element);
        }
        public void WriteToFile(string path)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (var item in items)
                {
                    sw.WriteLine(item);
                }
            }
        }
        public void ReadFromFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                Console.WriteLine(sr.ReadToEnd());
            }
                
        }
    
    }
}
