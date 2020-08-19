using System;
using System.Collections;
using System.Collections.Generic;

namespace LinkedListGeneric
{
    class Animal
    {
        public string Name { get; set; }
    }
    class Program
    {
       static public List<int> num;
        static public void Print()
        {
            
            foreach (int n in num)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine();
            Console.WriteLine("\n" + new string('-', 30));
        }
        static void Main(string[] args)
        {
            #region ArrayList
            /* ArrayList list = new ArrayList();
           list.Add(2.3);
           list.Add("Hello");
           list.Add('R');
           list.Add(100);

           foreach (object item in list)
           {
               Console.WriteLine(item);
           }
           Console.WriteLine(list.Contains(list));
           Console.WriteLine();
           list.AddRange(new double[] { 2.3, 3.5, 3.1 });

           for(int i = 0; i < list.Count; i++)
           {
               Console.Write(list[i] + " ");
           }
           Console.WriteLine("\n"+ new string('-',30));

           list.Insert(2, " world ");
           foreach (object i in list)
           {
               Console.Write(i + " ");
           }
           Console.WriteLine("\n" + new string('-', 30));
           Console.WriteLine();
           ArrayList sList = new ArrayList()
           {
               'l','o','v','e',' ','c', '#'
           };
           list.InsertRange(7, sList);
           foreach (object l in list)
           {
               Console.Write(" " + l);
           }
           Console.WriteLine("\n" + new string('-', 30));

           Console.WriteLine("Index('R') = {0}",list.IndexOf('R'));
           Console.WriteLine("LastIndex('R')= {0}", list.LastIndexOf('R'));
           list.Remove('l');
           Console.WriteLine("\n" + new string('-', 30));
           foreach (object k in list)
           {
               Console.Write(k);
           }
           Console.WriteLine("\n" + new string('-', 30));

           list.RemoveAt(list.LastIndexOf('#'));
           foreach (object k in list)
           {
               Console.Write(k);
           }

           Console.WriteLine("\n" + new string('-', 30));
           list.RemoveRange(3, 2);
           foreach (object k in list)
           {
               Console.Write(k);
           }
           list.Add( 90);
           list.Insert(3, 90);
           list.Insert(4, 90);
           foreach (object k in list)
           {
               Console.Write(k);
           }
           Print();
           Print();
           while (list.Contains(90))
           {
               list.Remove(90);
           }
           foreach (object k in list)
           {
               Console.Write(k);
           }
           Print();

           IEnumerator en = list.GetEnumerator();
           while (en.MoveNext())
           {
               Console.Write(en.Current + ", ");
           }
           Print();*/
            #endregion
            #region List<int>
            List<int> list = new List<int>() { 1, 2, 3, 4 };
            num = list;
            list.Add(5);
            List<int> SecondList = new List<int>(){6, 7, 8 };
            list.AddRange(SecondList);
            Print();
            list.Insert(8, 9);
            Print();
            list.RemoveAt(2);
            Print();
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal() { Name = " Cat "});
            animals.Add(new Animal() { Name = " Dog " });
            animals.Add(new Animal() { Name = " Monkey "});
            foreach (Animal p in animals)
            {
                Console.Write(p.Name);
            }
            #endregion
        }
    }
}
