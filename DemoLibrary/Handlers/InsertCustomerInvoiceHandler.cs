using DemoLibrary.Commands;
using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class InsertCustomerInvoiceHandler : IRequestHandler<InsertCustomerInvoiceCommand, CustomerInvoiceModel>
    {
        private readonly IDataAccess _data;

        public InsertCustomerInvoiceHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<CustomerInvoiceModel> Handle(InsertCustomerInvoiceCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.InsertCustomerInvoice(request.CustomerName, request.Amount));
        }
    }
}
