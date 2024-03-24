using Microsoft.AspNetCore.Mvc;
using Publisher.RabbitMq;
using System.ComponentModel.DataAnnotations;

namespace Publisher.Controllers;

[ApiController]
[Route("[controller]")]
public class OrderController : ControllerBase
{
    private readonly IMessageProducer _messageProducer;

    public OrderController(IMessageProducer messageProducer)
    {
        _messageProducer = messageProducer;
    }

    [HttpPost]
    public IActionResult CreateOrder(Order order)
    {
        _messageProducer.SendMessage(order);

        return Ok(new { id = order.Id });
    }

}

public class Order
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public decimal Price { get; set; }

    public int Quantity { get; set; }
}
