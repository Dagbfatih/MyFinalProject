using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    // SOLID
    //Open Closed Principle
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("-----------------------");

            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("-----------------------");

            foreach (var product in productManager.GetByUnitPrice(50, 100))
            {
                Console.WriteLine(product.ProductName);
            }
            //ProductManager productManager = new ProductManager(new InMemoryProductDal());

            //foreach (var product in productManager.GetAll())
            //{
            //    Console.WriteLine(product.ProductName);
            //}
            //Console.WriteLine();

            //ProductManager productManager2 = new ProductManager(new ABCProductDal());

            //foreach (var product in productManager2.GetAll())
            //{
            //    Console.WriteLine("Product name: " + product.ProductName);
            //    Console.WriteLine("Unit price: " + product.UnitPrice);
            //    Console.WriteLine("Unit in stock: " + product.UnitsInStock);
            //    Console.WriteLine();
            //}

            //foreach (var categoryId in productManager2.GetAllByCategory(2))
            //{
            //    Console.WriteLine(categoryId);
            //}

            //productManager2.List();
        }
    }
}
