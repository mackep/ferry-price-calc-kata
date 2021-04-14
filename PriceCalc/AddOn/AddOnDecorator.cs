namespace PriceCalc.AddOn
{
    public abstract class AddOnDecorator : Product
    {
        protected readonly Product Inner;

        protected AddOnDecorator(Product inner)
        {
            Inner = inner;
        }

        public override decimal BasePrice => Inner.BasePrice;
    }
}