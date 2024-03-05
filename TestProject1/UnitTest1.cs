using Xunit;
using Lopushok_K.model;
using System.Collections.Generic;

namespace TestProject1
{
    public class ProductFormTests
    {
        [Fact]
        public void DisplayProducts_Should_Display_Products_Correctly ()
        {
            List<Product> searchResults;

            // Arrange
            // Create an instance of ProductForm and populate the 'list' with test data
            List<Product> arrange = new List<Product>()
            {

            };
            // Act
            // Call the DisplayProducts method
            using (Lopushok_K.model.ModelDB db= new ModelDB())
            {

                searchResults = db.Product.Where(product =>
                product.Product_name.ToLower().Contains("Бумага 12") ||
                product.Type_product.ToLower().Contains("Бумага 12") ||
                product.Article.ToLower().Contains("Бумага 12") ||
                product.Min_agent_cost.ToString().Contains("Бумага 12")
            ).ToList();
            }
            // Assert
            // Verify that the UI displays the expected products
        }

        // Repeat a similar process for other display methods
    }
}
