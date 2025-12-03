using WWI.WebAPI.Repositories.Interfaces;
using WWI.WebAPI.Services.Interfaces;

namespace WWI.WebAPI.Services
{
    /// <summary>
    /// Service for invoice-related business logic.
    /// 
    /// Combines data from invoices, customers, and orders when needed.
    /// </summary>
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;
        private readonly ILogger<InvoiceService> _logger;

        public InvoiceService(IInvoiceRepository invoiceRepository, ILogger<InvoiceService> logger)
        {
            _invoiceRepository = invoiceRepository;
            _logger = logger;
        }
    }
}
