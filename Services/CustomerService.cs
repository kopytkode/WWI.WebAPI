using WWI.WebAPI.Repositories.Interfaces;
using WWI.WebAPI.Services.Interfaces;

namespace WWI.WebAPI.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepo;
        private readonly IPersonRepository _personRepo;
        private readonly ILogger<CustomerService> _logger;

        public CustomerService(ICustomerRepository customerRepo, IPersonRepository personRepo, ILogger<CustomerService> logger)
        {
            _customerRepo = customerRepo;
            _personRepo = personRepo;
            _logger = logger;

            //add a change
            int b = 1;
        }
    }
}
