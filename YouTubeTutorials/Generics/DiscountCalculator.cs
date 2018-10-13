namespace Generics
{
    public class DiscountCalculator<TProduct> where TProduct : Product
    {
        public float CalculateDiscount(TProduct product)
        {
            var discount = 1 / 5;
            var discountedProductPrice = discount * product.Price;
            return discountedProductPrice;
        }
    }
}
