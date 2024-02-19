namespace PizzaMauiApp.API.Dtos;

public class OrderItemDto
{
    public Guid OrderId { get; set; }
    public Guid ItemId { get; set; }
    public double Price { get; set; }
    public int Quantity { get; set; }
}