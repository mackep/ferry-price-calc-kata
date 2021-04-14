namespace PriceCalc.Fare
{
    public class KarlskronaGdynia : Product
    {
        public override string Description => "Karlskrona - Gdynia";

        public override decimal Price => BasePrice;

        public override decimal BasePrice => 2000;
    }
}