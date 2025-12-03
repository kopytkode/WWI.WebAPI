using WWI.WebAPI.Data;
using WWI.WebAPI.Repositories.Interfaces;

namespace WWI.WebAPI.Repositories
{
    public class OrderRepository : IOrderRepository
    {
        private readonly WideWorldContext _context;
        private readonly ILogger<OrderRepository> _logger;

        public OrderRepository(WideWorldContext context, ILogger<OrderRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
    }
}
