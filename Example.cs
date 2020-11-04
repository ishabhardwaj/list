using System;
using System.Collections.Generic; 
namespace GenericLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            //public string Name { get; set; }
            //Adding Item 
            /*List<string> myList=new List<string>
            {
             new myList {"Mahesh Chand"},  
             new myList {"Neel Beniwal"},  
             new myList {"Chris Love"}
            };*/
             List<string> myList = new List<string> { "Mahesh Chand", "Neel Beniwal", "Chris Love" };
            
            
           int choice =0;
           while (choice != 4)
         {

            Console.WriteLine("MENU");
            Console.WriteLine("What service do you need");
            Console.WriteLine("1. Get");
            Console.WriteLine("2. Post");
            Console.WriteLine("3. Put");
            Console.WriteLine("4. Delete");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
            case 1://get
            foreach(string s in myList)
            Console.WriteLine(s+" ");

            break;
            case 2:
                //Post Item in the middle
            myList.Insert(2,"Mathew");
            Console.WriteLine("\nInserting Mathew at index position 2");
            foreach(string s in myList)
            Console.WriteLine(s+" ");
            break;
            case 3:
            //post
                  myList.Add("Steven");
                  myList.Add("Clark");
                  myList.Add("Jack");
            break;
            case 4://delete
                 myList.Remove("Clark");
                 Console.WriteLine("\nRemoving Clark");
                 foreach(string s in myList)
                 Console.WriteLine(s+" ");
            break;
            default:
            Console.WriteLine("Sorry, invalid selection");
            break;
            }
            //Sorting List
            //myList.Sort();
            //Console.WriteLine("\n After Sorting");
            //foreach(string s in myList)
            //Console.Write(s.ToString()+" ");
            
        }
      }
    }
}    