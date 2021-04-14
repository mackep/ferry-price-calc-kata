namespace PriceCalc.AddOn
{
    public class Champagne : AddOnDecorator
    {
        public Champagne(Product inner) : base(inner)
        {
        }

        public override string Description => $"{Inner.Description}\n + Champagne";

        public override decimal Price => Inner.Price + 400;
    }
}