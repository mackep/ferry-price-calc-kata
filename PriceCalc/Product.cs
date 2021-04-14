namespace PriceCalc
{
    public abstract class Product
    {
        public abstract string Description { get; }

        public abstract decimal Price { get; }

        public abstract decimal BasePrice { get; }
    }
}