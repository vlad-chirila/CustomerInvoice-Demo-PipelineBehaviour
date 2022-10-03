using DemoLibrary.Models;
using System.Collections.Generic;
using System.Linq;

namespace DemoLibrary.DataAccess
{
    public class DemoDataAccess : IDataAccess
    {
        private List<CustomerInvoiceModel> customerInvoices = new();

        public DemoDataAccess()
        {
            customerInvoices.Add(new CustomerInvoiceModel { Id = 1, CustomerName = "Vlad", Amount = 100 });
            customerInvoices.Add(new CustomerInvoiceModel { Id = 2, CustomerName = "Jurgis", Amount = 256 });
        }

        public List<CustomerInvoiceModel> GetCustomerInvoices()
        {
            return customerInvoices;
        }

        public CustomerInvoiceModel InsertCustomerInvoice(string customerName, decimal amount)
        {
            CustomerInvoiceModel c = new() { CustomerName = customerName, Amount = amount };
            c.Id = customerInvoices.Max(x => x.Id) + 1;
            customerInvoices.Add(c);
            return c;
        }
    }
}
