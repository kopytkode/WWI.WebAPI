using WWI.WebAPI.Data;
using WWI.WebAPI.Repositories.Interfaces;

namespace WWI.WebAPI.Repositories
{
    /// <summary>
    /// Repository for managing invoice and billing data.
    /// 
    /// Uses the Entity: Invoices and InvoiceLines
    /// 
    /// Invoices are created when sales orders are fulfilled.
    /// Provides data access methods for invoice headers and lines.
    /// </summary>
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly WideWorldContext _context;
        private readonly ILogger<InvoiceRepository> _logger;

        public InvoiceRepository(WideWorldContext context, ILogger<InvoiceRepository> logger)
        {
            _context = context;
            _logger = logger;
        }
    }
}
