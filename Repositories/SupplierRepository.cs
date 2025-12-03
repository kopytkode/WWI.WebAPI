using WWI.WebAPI.Data;
using WWI.WebAPI.Repositories.Interfaces;

namespace WWI.WebAPI.Repositories
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly WideWorldContext _context;
        private readonly ILogger<SupplierRepository> _logger;

        public SupplierRepository(WideWorldContext context, ILogger<SupplierRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
    }
}
