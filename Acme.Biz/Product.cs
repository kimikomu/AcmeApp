using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Acme.Common;

namespace Acme.Biz
{
    /// <summary>s
    /// Manages products carried in inventory
    /// </summary>
    public class Product
    {
        public string ProductName { get; set; }
        public string Description { get; set; } 
        public int ProductId { get; set; }

        public Product()
        {
            Console.WriteLine("Product instance created.");
        }

        public Product(string productName, string description, int productId): this()
        {
            ProductName = productName;
            Description = description;
            ProductId = productId;
            Console.WriteLine($"Product instance has a name: {ProductName}.");
        }

        public string SayHello()
        {
            // access a class within this component
            var vendor = new Vendor();
            vendor.SendWelcomeEmail("Message from Product.");

            // access a class in a different component
            var confirmation = new EmailService();
            confirmation.SendMessage("New Product", this.ProductName, "sales@abc.com");

            // access a static class
            var log = LoggingService.LogAction("Saying hello");

            return $"Hello {ProductName} ({ProductId}): {Description}";
        }
    }
}
