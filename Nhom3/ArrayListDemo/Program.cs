using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListDemo
{
    class Program
    {
        static List<Tudien> alist = new List<Tudien>() {
        new Tudien("lam" , "duc"),
        new Tudien("hoang" , "van"),
        new Tudien("hello" , "xin chao"),
        new Tudien("go" , "di")};
        static void Main(string[] args)
        {


            while (true)
            {
                Console.WriteLine("-------- Dictionary ----------");
                Console.WriteLine("1, Add");
                Console.WriteLine("2, Delete");
                Console.WriteLine("3, Seacrh");
                Console.WriteLine("4, Update");
                Console.WriteLine("5, Show ALL");
                Console.WriteLine("6, Exit");
                try
                {
                    int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Console.WriteLine("Enter key : ");
                            Program.AddDictionary(Console.ReadLine());
                            break;
                        case 2:
                            Console.WriteLine("enter key to delete : ");
                            Program.DeleteDictionary(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("enter key to search : ");
                            SearchDictionary(Console.ReadLine());
                            break;
                        case 4:
                            Console.WriteLine("Enter key to update : ");
                            UpdateDictionary(Console.ReadLine());
                            break;
                        case 5:
                            Program.Output();
                            break;

                        case 6:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Please enter number 1-6");
                            break;
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Please enter number 1-6");
                }



            }
        }


        //Add
        public static void AddDictionary(string key)
        {
            int count = 0;
            for (int i = 0; i < alist.Count; i++)
            {
                if (alist[i].key == key)
                {
                    count = 0;
                    Console.WriteLine("\"{0}\" already exists !",key);
                    break;
                }
                else
                {
                    count = 1;
                   
                }
            }
            if (count >= 1)
            {
                Console.WriteLine("Enter value: ");
                string value = Console.ReadLine();
                alist.Add(new Tudien(key, value));
                Console.WriteLine("Add succes !");
            }
        }
        

        // Delete 
        public static void DeleteDictionary(string key)
        {
            int count = 0;
            for (int i = 0; i < alist.Count; i++)
            {
                
                if (alist[i].key == key)
                {
                    count = 0;
                    alist.Remove(alist.Find(x => x.key == key));
                    Console.WriteLine("Remove succes !");
                    break;
                }
                else
                {
                    count = 1;
                }
                
            }
            if (count == 1)
            {
                Console.WriteLine("\"{0}\" does not exist !", key);
            }

        }

        // search 
        public static void SearchDictionary(string key)
        {
            int length = alist.Count;
            var fin = alist.Find(x =>
            {
                return x.key == key;
            });

            Console.WriteLine(fin);
        }

        // Update
        public static void UpdateDictionary(string key)
        {
            
            int count = 0;
            for (int i = 0; i < alist.Count; i++)
            {

                if (alist[i].key == key)
                {
                    count = 0;
                    Console.WriteLine("enter value to update : ");
                    string value = Console.ReadLine();
                    alist[i].value = value;
                    Console.WriteLine("Update succes !");
                    break;
                }
                else
                {
                    count = 1;
                }

            }
            if (count == 1)
            {
                Console.WriteLine("\"{0}\" does not exist !", key);
            }

        } 

        //out
        public static void Output()
        {
            foreach (var item in alist)
            {
                Console.WriteLine(item.key + " - "+item.value);
            }


            
        }
    }
    class Tudien
    {
        public string value { get; set; }
        public string key { get; set; }

        public Tudien(string key , string value)
        {
            this.key = key;
            this.value = value;
        }

    public Tudien()
    {
    }

        public override string ToString()
        {
            return key +" : "+ value;
        }
    }
}
