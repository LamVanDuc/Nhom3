using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    class Program
    {
           Hashtable dictionary = new Hashtable();
            
            static void Main(string[] args)
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
                try { 
                int choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            program.AddDictionary();
                            break;
                        case 2:
                            program.DeleteDictionary();
                            break;
                        case 3:
                            program.SearchDictionary();
                            break;
                        case 4: program.UpdateDictionary();
                            break;
                        case 5:
                            program.Output();
                            break;

                        case 6 :
                            Environment.Exit(0);
                            break;
                        default: Console.WriteLine("Please enter number 1-6");
                            break;
                    }
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Please enter number 1-6");
                }
               
            }

            }


              // add
            public void AddDictionary()
            {
                    Console.WriteLine("Enter key : ");
                    string key = Console.ReadLine();
           
                if (dictionary.ContainsKey(key))
                {
                    Console.WriteLine("key already exists !");
                }
                else
                {
                    Console.WriteLine("Enter value: ");
                    string value = Console.ReadLine();
                    dictionary.Add(key, value);
                    Console.WriteLine("Add succes !");
                }

            }

        //Delete
            public void DeleteDictionary()
            {
                    Console.WriteLine("enter key to delete : ");

                    string key = Console.ReadLine();
                    
                    if (dictionary.ContainsKey(key) == true)
                    {
                    dictionary.Remove(key);
                    Console.WriteLine("Delete success !");
                    }
            }

       

        //search
        public void SearchDictionary()
        {
            Console.WriteLine("enter key to search : ");
            string key = Console.ReadLine();

            if (dictionary.ContainsKey(key)==true)
            {
                Console.WriteLine(dictionary[key]);
            }
            else
            {
                Console.WriteLine("Not found key : {0}",key);
            }
            

        }

        public void UpdateDictionary()
        {
            Console.WriteLine("Enter key to update : ");
            string key = Console.ReadLine();
            
            if (dictionary.ContainsKey(key))
            {
                Console.WriteLine("Enter  value to update : ");
                string value = Console.ReadLine();
                dictionary[key] = value;
                Console.WriteLine("Uptade key {0} succcess ! ",key);
            }
            else
            {
                Console.WriteLine("Not found key : {0} !", key);
            }
            
        }


        public void Output()
        {

            Console.WriteLine("key        value");
            foreach (DictionaryEntry item in dictionary)
            {
                Console.WriteLine(item.Key + "        "+item.Value);
            }

               
         }
    }
    
}


    


