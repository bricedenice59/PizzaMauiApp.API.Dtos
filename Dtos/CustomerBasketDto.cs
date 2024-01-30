namespace PizzaMauiApp.API.Dtos;

public class CustomerBasketDto
{
    public required string CustomerId { get; set; }
    public List<BasketItemDto> Items { get; set; } = new();
}