namespace PriceCalc.AddOn
{
    public class Flexi : AddOnDecorator
    {
        public Flexi(Product inner) : base(inner)
        {
        }

        public override string Description => $"{Inner.Description}\n + Flexi";

        public override decimal Price => Inner.Price + Inner.BasePrice * 0.1M;
    }
}