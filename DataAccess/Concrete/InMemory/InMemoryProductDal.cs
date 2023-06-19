using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        private Product productToDelete;

        public InMemoryProductDal()
        {
            _products = new List<Product>
                {
                    new Product{ProductID=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                    new Product{ProductID = 2, CategoryId = 1, ProductName = "Kamera", UnitPrice = 1500, UnitsInStock = 5 },
                    new Product{ProductID = 3, CategoryId = 2, ProductName = "Telefon", UnitPrice = 750, UnitsInStock = 21 },
                    new Product{ProductID=4, CategoryId=2, ProductName="Klavye", UnitPrice=150, UnitsInStock=200},
                    new Product{ProductID=5, CategoryId=2, ProductName="Fare", UnitPrice=85, UnitsInStock=1}
                };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Add(Category entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product product)
        {
            //Product productToDelete = null;
            //foreach (var p in _products)
            //{
            //    if (product.ProductId == p.ProductId)
            //    {
            //        productToDelete = p;

            //    }

            //}
            Product productToDelete = _products.SingleOrDefault(p => p.ProductID == product.ProductID);

            _products.Remove(productToDelete);
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllCategory(int categoryId)
        {
           return _products.Where(p=>p.CategoryId== categoryId).ToList();
        }

        public List<ProductDetailDto> GetProductDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            //Gönderdiğim ürün ıd sine sahip listedeki ürünü bul demek 
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductID == product.ProductID);
            productToUpdate.ProductName=product.ProductName;
            productToUpdate.CategoryId=product.CategoryId;
            productToUpdate.UnitPrice=product.UnitPrice;
            productToUpdate.UnitsInStock=product.UnitsInStock;
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }
}
