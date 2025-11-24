using Stock;
using System.Threading;
using Xunit;
namespace Stock.Test
{
    public class StockTest
    {
        [Fact]
        public void FindExistingProductTest()
        {
            // Arrange
            // Act
            // Assert
            var stock = new Stock();
            stock.AddProduct(new Product("Mouse", 670.99m));
            stock.AddProduct(new Product("keyboard", 1250.99m));
            stock.AddProduct(new Product("PC", 7999.99m));

            var found = stock.FindProductById(2);

            Assert.NotNull(found);
            Assert.Equal("Mouse", found.Name);
        }

        [Fact]
        public void FindNotExistingProductTest()
        {
            var stock = new Stock();

            var result = stock.FindProductById(5);

            Assert.Null(result);
        }
    }
}
