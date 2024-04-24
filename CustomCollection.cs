using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Generic
{
    class CustomCollection<T> where T : Person
    {
        private List<T> items;

        public CustomCollection()
        {
            items = new List<T>();
        }

        public void Add(T item)
        {
            items.Add(item);
        }

        public T GetById(int id)
        {
            foreach (T item in items)
            {
                if (item.Id == id)
                    return item;
            }
            return null;
        }

        public void PrintAllEmployees()
        {
            foreach (T item in items)
            {
                Console.WriteLine($"Id: {item.Id}, Ad: {item.Name}, Soyad: {item.Surname}, Yas: {item.Age}");
            }
        }
    }
}
