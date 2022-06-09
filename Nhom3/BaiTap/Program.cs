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
                

                program.Output();

            while (true)
            {
                Console.WriteLine("--------tra cuu tu dien ----------");
                Console.WriteLine("1, them tu dien");
                Console.WriteLine("2, xoa tu dien");
                Console.WriteLine("3, tim tu dien");
                Console.WriteLine("4, sửa từ điển");
                Console.WriteLine("5, hien thi tat ca");
                Console.WriteLine("6, exit");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1 :
                        program.AddDictionary();
                        break;
                    case 2:
                        program.DeleteDictionary();
                        break;
                    case 3: program.SearchDictionary();
                        break;
                    case 5: program.Output();
                        break;

                    default: break;
                }
            }

            }


              // add
            public void AddDictionary()
            {
                Console.WriteLine("Enter key : ");
                string key = Console.ReadLine();
                Console.WriteLine("Enter value: ");
                string value = Console.ReadLine();

                dictionary.Add(key, value);
            
                Console.WriteLine("Add : {0}",dictionary.ContainsKey(key));


            }

        //Delete
            public void DeleteDictionary()
            {
                    Console.WriteLine("enter key to delete : ");

                    string key = Console.ReadLine();
                    dictionary.Remove(key);
                if (dictionary.ContainsKey(key) == false)
                {
                    Console.WriteLine("xoa thanh cong !");
                }
            }

       

        //search
        public void SearchDictionary()
        {
            Console.WriteLine("enter key to search : ");
            string key = Console.ReadLine();
            int count = 0;

            Console.WriteLine(dictionary[key]);
        }
        public void Output()
        {

            foreach (DictionaryEntry item in dictionary)
            {
                Console.WriteLine(item.Key + "  -  "+item.Value);
            }
               
         }
    }
    class Diction
    {
       string key;
        string value;


        public Diction(string key , string value)
        {
            this.key = key;
            this.value = value;
        }
        public string Key { get; set; }
        public string Value { get; set; }

    }
}


    


