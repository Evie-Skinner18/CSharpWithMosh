namespace Interfaces
{
    public class Order
    {
        public Shipment Shipment;
        public float TotalPrice;
        public bool IsShipped { get; set; }

    }
}
