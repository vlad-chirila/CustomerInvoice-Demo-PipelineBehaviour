using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace DemoLibrary.Handlers
{
    public class GetCustomerInvoiceByIdHandler : IRequestHandler<GetCustomerInvoiceByIdQuery, CustomerInvoiceModel>
    {
        private readonly IMediator _mediator;

        public GetCustomerInvoiceByIdHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<CustomerInvoiceModel> Handle(GetCustomerInvoiceByIdQuery request, CancellationToken cancellationToken)
        {
            var results = await _mediator.Send(new GetCustomerInvoiceListQuery());

            var output = results.FirstOrDefault(x => x.Id == request.Id);

            return output;
        }
    }
}
