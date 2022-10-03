using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Queries
{
    public record GetCustomerInvoiceByIdQuery(int Id) : IRequest<CustomerInvoiceModel>;
}
