using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace SortedListDemo
{
    class Program
    {

        SortedList lists = new SortedList(new CaseInsensitiveComparer());
        static void Main(string[] args)
        {
            {
                Program program = new Program();
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
                                program.AddDictionary(Console.ReadLine());
                                break;
                            case 2:
                                Console.WriteLine("enter key to delete : ");
                                program.DeleteDictionary(Console.ReadLine());
                                break;
                            case 3:
                                Console.WriteLine("enter key to search : ");
                                program.SearchDictionary(Console.ReadLine());
                                break;
                            case 4:
                                Console.WriteLine("Enter key to update : ");
                                program.UpdateDictionary(Console.ReadLine());
                                break;
                            case 5:
                                program.Output();
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
        }

        //Add
        public void AddDictionary(string key)
        {
            if (lists.Contains(key))
            {
                Console.WriteLine("key already exists !");
            }
            else
            {
                Console.WriteLine("Enter value :");
                string value = Console.ReadLine();
                lists.Add(key , value);
                Console.WriteLine("Add success !");
            }
        }

        // Delete 
        public void DeleteDictionary(string key)
        {
            if (lists.ContainsKey(key))
            {
                lists.Remove(key);
                Console.WriteLine("delete success !");
            }
            else
            {
                Console.WriteLine("Delete false , \"{0}\" does not exist !", key);
            }
        }

        // search 
        public void SearchDictionary(string key)
        {
            if (lists.ContainsKey(key))
            {
                Console.WriteLine("key : {0} | value : {1}",key,lists[key]);
            }
            else
            {
                Console.WriteLine("\"{0}\" does not exist !", key);
            }
        }

        // Update
        public void UpdateDictionary(string key)
        {
            if (lists.ContainsKey(key))
            {
                Console.WriteLine("enter value to Update : ");
                string value = Console.ReadLine();
                lists[key] = value;
                Console.WriteLine("Update success !");
            }
            else
            {
                Console.WriteLine("Update false , \"{0}\" does not exist !", key);
            }
        }

        public void Output()
        {
            foreach (DictionaryEntry item in lists)
            {
                Console.WriteLine(item.Key +"  -  "+item.Value);
            }
        }
    }
}
