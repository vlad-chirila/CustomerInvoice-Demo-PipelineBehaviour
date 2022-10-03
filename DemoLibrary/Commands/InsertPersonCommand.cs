using DemoLibrary.Models;
using MediatR;

namespace DemoLibrary.Commands
{
    public record InsertCustomerInvoiceCommand(string CustomerName, decimal Amount) : IRequest<CustomerInvoiceModel>;

    public class InsertCustomerInvoiceCommandClass : IRequest<CustomerInvoiceModel>
    {
        public string CustomerName { get; set; }
        public decimal Amount { get; set; }

        public InsertCustomerInvoiceCommandClass(string customerName, decimal amount)
        {
            CustomerName = customerName;
            Amount = amount;
        }
    }
}
