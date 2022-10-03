using DemoLibrary.Commands;
using DemoLibrary.Models;
using DemoLibrary.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerInvoiceController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CustomerInvoiceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // GET: api/<CustomerInvoiceController>
        [HttpGet]
        public async Task<List<CustomerInvoiceModel>> Get()
        {
            return await _mediator.Send(new GetCustomerInvoiceListQuery());
        }

        // GET api/<CustomerInvoiceController>/5
        [HttpGet("{id}")]
        public async Task<CustomerInvoiceModel> Get(int id)
        {
            return await _mediator.Send(new GetCustomerInvoiceByIdQuery(id));
        }

        // POST api/<CustomerInvoiceController>
        [HttpPost]
        public async Task<CustomerInvoiceModel> Post([FromBody] CustomerInvoiceModel value)
        {
            var model = new InsertCustomerInvoiceCommand(value.CustomerName, value.Amount);
            return await _mediator.Send(model);
        }
    }
}
