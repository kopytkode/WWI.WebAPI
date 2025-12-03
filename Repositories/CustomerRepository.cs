using WWI.WebAPI.Data;
using WWI.WebAPI.Repositories.Interfaces;

namespace WWI.WebAPI.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly WideWorldContext _context;
        private readonly ILogger<CustomerRepository> _logger;

        public CustomerRepository(WideWorldContext context, ILogger<CustomerRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
    }
}
