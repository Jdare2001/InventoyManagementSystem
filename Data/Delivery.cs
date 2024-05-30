public class Delivery
{
    public int Id { get; set; }
    public int ItemId { get; set; }
    public int Quantity { get; set; }
    public DateTime DeliveryDate { get; set; }
    public Item Item { get; set; }
}