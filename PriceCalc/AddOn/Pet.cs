namespace PriceCalc.AddOn
{
    public class Pet : AddOnDecorator
    {
        public Pet(Product inner) : base(inner)
        {
        }

        public override string Description => $"{Inner.Description}\n + Pet";

        public override decimal Price => Inner.Price + 300;
    }
}