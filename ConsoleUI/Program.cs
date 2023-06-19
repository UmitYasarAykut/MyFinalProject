using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
   class Program
    {
        static void Main(string[] args)
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }

            {
                ProductManager productManager = new ProductManager(new EfProductDal());
                foreach (var product in productManager.GetProductDetails())
                {
                    Console.WriteLine(product.ProductName+ "----"+ product.CategoryName);
                }
            }






        }
    }
}
