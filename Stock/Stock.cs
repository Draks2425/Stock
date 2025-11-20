using System;
using System.Collections.Generic;
using System.Text;

namespace Stock
{
    public class Stock
    {
        public List<Product> Products { get; set; } = new List<Product>();
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }
        public Product FindProductById(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }

        public Product GetProductById(int id)
        {
            var product = FindProductById(id);
            if (product != null)
            {
                Products.Remove(product);
            }
            return product;
        }
    }
}
