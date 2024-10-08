using CashFlow.Communication.Requests;
using FluentValidation;

namespace CashFlow.Application.UseCases.Expenses.Register
{
    public class RegisterExpanseValidator : AbstractValidator<RequestRegisterExpenseJson>
    {
        public RegisterExpanseValidator()
        {
            RuleFor(expanse => expanse.Title).NotEmpty().WithMessage("The name is required.");
            RuleFor(expanse => expanse.Description).NotEmpty().WithMessage("The description is required.");
            RuleFor(expanse => expanse.Amount).GreaterThan(0).WithMessage("The amount must be greater than zero.");
            RuleFor(expanse => expanse.Date).LessThanOrEqualTo(DateTime.UtcNow).WithMessage("The date not should be bigger that the current.");
            RuleFor(expanse => expanse.PaymentType).IsInEnum().WithMessage("Payment type is not valid.");
        }
    }
}
