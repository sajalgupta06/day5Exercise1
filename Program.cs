using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppExercise1
{

    internal class Program
    {
        static void Main(string[] args)
        {

            ArrayList fruits = new ArrayList();

            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("cherry");
            fruits.Add("date");
            fruits.Add("elderberry");

            Console.WriteLine("Total number of elements is : " + fruits.Count);
            foreach(var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.WriteLine("\n");
          
            while (true)
            {
                Console.WriteLine("1. Insert Item \t 2. Remove Item\t 3.Search Item\t 4 Print List");
                int res = int.Parse(Console.ReadLine());
                Console.WriteLine("Input Item");
                if (res == 4)
                {
                    foreach (var fruit in fruits) { Console.WriteLine(fruit); }

                }
                else
                {
                    string item = Console.ReadLine();
                    switch (res)
                    {
                        case 1:
                            {
                                int index = int.Parse(Console.ReadLine());
                                fruits.Insert(index,item);
                                Console.WriteLine(item + " is added at " + index);
                                break;
                            }
                        case 2:
                            {
                                fruits.Remove(item);
                                Console.WriteLine(item + " is removed");
                                break;
                            }
                        case 3:
                            {
                                if (fruits.Contains(item))
                                {
                                    Console.WriteLine("Item Found: " + item);
                                }
                                else
                                {
                                    Console.WriteLine("Item Not Found");
                                }
                                break;
                            }
                        case 4:
                            {
                                foreach (var fruit in fruits) { Console.WriteLine(fruit); }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid operation");
                                break;
                            }



                    }

                }

            }


            Console.ReadKey();

        }
    }
}
