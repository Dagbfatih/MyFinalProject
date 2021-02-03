using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products; // global değişkenler _ ile başlar ( class içinde global )
        List<Category> _categories;
        public InMemoryProductDal()
        {
            _products = new List<Product> {
                new Product{ProductId=1, CategoryId=1, ProductName="Bardak", UnitPrice=15, UnitsInStock=15},
                new Product{ProductId=2, CategoryId=1, ProductName="Kamera", UnitPrice=500, UnitsInStock=3},
                new Product{ProductId=3, CategoryId=2, ProductName="Telefon", UnitPrice=1500, UnitsInStock=2},
                new Product{ProductId=4, CategoryId=2, ProductName="Klavye", UnitPrice=150, UnitsInStock=65},
                new Product{ProductId=5, CategoryId=2, ProductName="Fare", UnitPrice=85, UnitsInStock=1}
            };

            _categories = new List<Category>
            {
                new Category{CategoryId=1, CategoryName="Kapkacak"},
                new Category{CategoryId=2, CategoryName="Teknoloji"}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            // LINQ - Language Integrated Query
            // Lambda - => // Her p için: p.ProductId == product.ProductId ise 
            // SingleOrDefault demek foreach dmeektir. _products'ı dolaşır ve her seferinde p için p.ProductId == product.ProductId ise productsToDelete = p; yap. Demektir
            Product productToDelete = _products.SingleOrDefault(p => p.ProductId == product.ProductId);

            _products.Remove(productToDelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            return _products;
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            // where şunu yapar: içindeki şarta uyan bütün değerleri bir listeye atar
            return _products.Where(p => p.CategoryId == categoryId).ToList();
        }

        public void List()
        {
            Category category;
            foreach (var p in _products)
            {
                category = _categories.SingleOrDefault(c => c.CategoryId == p.CategoryId);
                Console.WriteLine("Name: " + p.ProductName);
                Console.WriteLine("category name: " + category.CategoryName);
            }
        }

        public void List(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            // gönderdiğim ürün Id'sine sahip olan listedeki ürünü bul
            Product productToUpdate = _products.SingleOrDefault(p => p.ProductId == product.ProductId);
            productToUpdate.ProductName = product.ProductName;
            productToUpdate.CategoryId = product.CategoryId;
            productToUpdate.UnitPrice = product.UnitPrice;
            productToUpdate.UnitsInStock = product.UnitsInStock;
        }


    }
}
