using System.IO;

namespace PriceCalc.Printing
{
    public class FileReceiptPrinter : IReceiptPrinter
    {
        public void Print(Product product)
        {
            using var writer = new StreamWriter("Receipt.txt");
            writer.WriteLine(product.Description);
            writer.WriteLine($"Total: {product.Price}");
        }
    }
}