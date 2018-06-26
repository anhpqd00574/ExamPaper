using ApplicationProgramming.entity;
using System;
using System.Collections.Generic;
using System.Text;
namespace ApplicationProgramming.controller
{
    class ProductController
    {
        private static List<Product> listProduct = new List<Product>();

        public static bool AddProduct()
        {
            var product = new Product();
            Console.WriteLine("Enter ProductId :");
            product.productId = Console.ReadLine();
            Console.WriteLine("Enter name:");
            product.productName = Console.ReadLine();
            Console.WriteLine("Enter price:");
            product.price = Console.ReadLine();
            Console.WriteLine("Add new Sucess.");
            listProduct.Add(product);
            return true;
        }

        public static void DisplayList()
        {
            Console.WriteLine("{0, -20} {1, -20} {2, -20}","ProductId", "Name", "Price");
            Console.WriteLine("------------------------------------------------");
            foreach (var product in listProduct)
            {
                Console.WriteLine("{0, -20} {1, -20} {2, -20}", product.productId, product.productName, product.price);
            }
            Console.ReadLine();
        }

        public static void DeleteById()
        {
            Console.WriteLine("Please enter Id to delete: ");
            var id = Console.ReadLine();

            Product delete = listProduct.Find(a => a.productId == id);
            listProduct.Remove(delete);
            }
        }
    }
