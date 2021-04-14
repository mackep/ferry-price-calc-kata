namespace PriceCalc.AddOn
{
    public class AllInclusive : AddOnDecorator
    {
        public AllInclusive(Product inner) : base(inner)
        {
        }

        public override string Description => $"{Inner.Description}\n + All-Inclusive";

        public override decimal Price => Inner.Price + GetAddOnPrice;

        public decimal GetAddOnPrice
        {
            get
            {
                if (Inner.BasePrice < 1500)
                    return 800;

                return 1200;
            }
        }
    }
}