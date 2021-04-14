namespace PriceCalc.Fare
{
    public class GothenburgKiel : Product
    {
        public override string Description => "Gothenburg - Kiel";

        public override decimal Price => BasePrice;

        public override decimal BasePrice => 1000;
    }
}