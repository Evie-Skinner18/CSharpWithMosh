namespace Interfaces
{
    public class Order
    {
        public Shipment Shipment;
        public bool IsShipped => true;
        public float TotalPrice;
    }
}
