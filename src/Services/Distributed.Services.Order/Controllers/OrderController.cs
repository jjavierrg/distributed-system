using Microsoft.AspNetCore.Mvc;

namespace Distributed.Services.Order.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController
    {
        [HttpGet("{orderId}")]
        public Task<OrderDto> GetOrder(Guid orderId)
        {
            return Task.FromResult(new OrderDto(orderId));
        }

        [HttpPost]
        public Task<Guid> AddOrder(OrderDto order)
        {
            return Task.FromResult(Guid.NewGuid());
        }


        public record OrderDto(Guid orderId);
    }
}