namespace PizzaMauiApp.API.Dtos;

public class OrderDto
{
    public Guid Id { get; set; }
    public string UserId { get; set; } = null!;
    
    public ICollection<OrderItemDto> OrderItems { get; set; } = new List<OrderItemDto>(); 

    // public ICollection<OrderStatusUpdate> OrdersStatusHistory { get; } = new List<OrderStatusUpdate>(); 
}