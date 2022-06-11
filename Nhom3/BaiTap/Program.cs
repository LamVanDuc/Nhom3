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
            public void AddDictionary(string key)
            {

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
        public void DeleteDictionary(string key)
        {                   
             if (dictionary.ContainsKey(key) == true)
             {
                dictionary.Remove(key);
                Console.WriteLine("Delete success !");
             }
             else
             {
                Console.WriteLine("\"{0}\" does not exist !",key);
             }
        }

       

        //search
        public void SearchDictionary(string key)
        {
            if (dictionary.ContainsKey(key)==true)
            {
                Console.WriteLine("key: {0}  \nValue :  {1} ",key,dictionary[key]);
            }
            else
            {
                Console.WriteLine("Not found key : {0}",key);
            }
            

        }

        public void UpdateDictionary(string key)
        {    
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

            foreach (DictionaryEntry item in dictionary)
            {
                Console.WriteLine(item.Key + "        "+item.Value);
            }

               
         }
    }
    
}


    


