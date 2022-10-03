using DemoLibrary.Models;
using System.Collections.Generic;

namespace DemoLibrary.DataAccess
{
    public interface IDataAccess
    {
        List<CustomerInvoiceModel> GetCustomerInvoices();
        CustomerInvoiceModel InsertCustomerInvoice(string customerName, decimal amount);
    }
}