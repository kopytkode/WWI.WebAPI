using WWI.WebAPI.Data;
using WWI.WebAPI.Repositories.Interfaces;

namespace WWI.WebAPI.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly WideWorldContext _context;
        private readonly ILogger<PersonRepository> _logger;

        public PersonRepository(WideWorldContext context, ILogger<PersonRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
    }
}
