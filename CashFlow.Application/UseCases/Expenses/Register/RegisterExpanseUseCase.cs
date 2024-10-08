using CashFlow.Communication.Enums;
using CashFlow.Communication.Requests;
using CashFlow.Communication.Responses;
using CashFlow.Exception.BasesException;

namespace CashFlow.Application.UseCases.Expenses.Register
{
    public class RegisterExpanseUseCase
    {
        public ResponseRegisterExpanseJson Execute(RequestRegisterExpenseJson request)
        {
            Validate(request);

            return new ResponseRegisterExpanseJson();
        }

        public void Validate(RequestRegisterExpenseJson request)
        {
            var validator = new RegisterExpanseValidator();
            var result = validator.Validate(request);
            if (result.IsValid == false)
            {
                var errorsMessage = result.Errors.Select(f => f.ErrorMessage).ToList();

                throw new ErrorOnValidationException(errorsMessage);
            }
        }
    }
}