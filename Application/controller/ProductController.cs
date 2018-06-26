using System;
using System.Collections.Generic;
using Application.entity;

namespace Application.controller
{
    public class ProductController
    {
        List<Product> list = new List<Product>();
        
        public void AddProduct()
        {
            var product = new Product();
            Console.WriteLine("Enter the product code : ");
            product.ProductId = Console.ReadLine();
            Console.WriteLine("Enter the product name : ");
            product.ProductName = Console.ReadLine();
            Console.WriteLine("Enter the product price : ");
            product.Price = Console.ReadLine();
            list.Add(product);
        }

        public void DisplayProduct()
        {
            Console.WriteLine("{0, -10}{1, -10}{2, -10}", "Product ID", "Product Name", "Price");
            foreach (var p in list)
            {
                Console.WriteLine("{0, -10}{1, -10}{2, -10}", p.ProductId, p.ProductName, p.Price);
            }
        }

        public void DeleteProduct()
        {
            Console.WriteLine("Enter the product code : ");
            var productid = Console.ReadLine();
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ProductId == productid)
                {
                    list.RemoveAt(i);
                }
            }
        }
    }
}