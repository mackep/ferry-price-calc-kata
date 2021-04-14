using System;

namespace PriceCalc.Printing
{
    public class ConsoleReceiptPrinter : IReceiptPrinter
    {
        public void Print(Product product)
        {
            Console.WriteLine(product.Description);
            Console.WriteLine($"Total price: {product.Price}\n");
        }
    }
}