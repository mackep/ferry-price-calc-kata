namespace PriceCalc.AddOn
{
    public class BreakfastBuffet : AddOnDecorator
    {
        public BreakfastBuffet(Product inner) : base(inner)
        {
        }

        public override string Description => $"{Inner.Description}\n + Breakfast Buffet";

        public override decimal Price => Inner.Price + 150;
    }
}