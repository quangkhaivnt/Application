using System;
using System.Collections.Generic;
using Application.controller;
using Application.entity;

namespace Application
{
    class Program
    {
        
        private static ProductController _controller = new ProductController();
        public static void GenerateMenu()
        {
            while (true)
            {
                Console.WriteLine("---------------------Application-----------------");
                Console.WriteLine("1.Add product records");
                Console.WriteLine("2.Display product records");
                Console.WriteLine("3.Delete product records");
                Console.WriteLine("4.Exit");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Please enter your choice (1 | 2 | 3 | 4) : ");
                int choice = Int32.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Add product records");
                        _controller.AddProduct();
                        Console.WriteLine("Press enter to enter");
                        Console.ReadLine();
                        break;
                    case 2:
                        Console.WriteLine("Display product records");
                        _controller.DisplayProduct();
                        Console.WriteLine("Press enter to enter");
                        Console.ReadLine();
                        break;
                    case 3:
                        Console.WriteLine("Delete product records");
                        _controller.DeleteProduct();
                        Console.WriteLine("Press enter to enter");
                        Console.ReadLine();
                        break;
                    case 4:
                        Console.WriteLine("Exit success");
                        Environment.Exit(1);
                        break;
                    default:
                        Console.WriteLine("Incorrect selection. Please retype.");
                        break;
                }
            }
        }
        static void Main(string[] args)
        {
            GenerateMenu();
        }

        
    }
}