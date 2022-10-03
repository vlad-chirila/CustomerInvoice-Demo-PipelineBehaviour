namespace DemoLibrary.Validation
{
    using DemoLibrary.Queries;
    using FluentValidation;

    public class GetCustomerInvoiceByIdQueryValidation : AbstractValidator<GetCustomerInvoiceByIdQuery>
    {
        public GetCustomerInvoiceByIdQueryValidation()
        {
            RuleFor(x => x.Id)
                .NotEmpty();
        }
    }
}