using ApplicationProgramming.controller;
using System;

namespace ApplicationProgramming
{
    class Program
    {

        static void Main(string[] args)
        {
            while (true)
            {
                
                Console.WriteLine("---------Menu Product---------");
                Console.WriteLine("1. Add new product.");
                Console.WriteLine("2. Display product records");
                Console.WriteLine("3. Delete product by Id.");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Pls enter your choice");
                var choice = Int16.Parse(Console.ReadLine());
                switch (choice) {
                    case 1:
                        Console.WriteLine("Add new product.");
                        ProductController.AddProduct();
                        Console.ReadLine();
                        break;
                    case 2:
                        ProductController.DisplayList();
                        break;
                    case 3:
                   
                        ProductController.DeleteById();
                        Console.WriteLine("Deleted.");
                        break;
                    case 4:

                        Console.WriteLine("Bye.");
                        Environment.Exit(0);
                        break;
                }
            }
        }
    }
}
