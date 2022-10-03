using DemoLibrary.DataAccess;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetCustomerInvoiceListHandler : IRequestHandler<GetCustomerInvoiceListQuery, List<CustomerInvoiceModel>>
    {
        private readonly IDataAccess _data;

        public GetCustomerInvoiceListHandler(IDataAccess data)
        {
            _data = data;
        }

        public Task<List<CustomerInvoiceModel>> Handle(GetCustomerInvoiceListQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_data.GetCustomerInvoices());
        }
    }
}
