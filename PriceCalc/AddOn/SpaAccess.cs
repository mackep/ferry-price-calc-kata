namespace PriceCalc.AddOn
{
    public class SpaAccess : AddOnDecorator
    {
        public SpaAccess(Product inner) : base(inner)
        {
        }

        public override string Description => $"{Inner.Description}\n + SpaAccess";

        public override decimal Price => Inner.Price + 350;
    }
}