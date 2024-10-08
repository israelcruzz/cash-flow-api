using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashFlow.Exception.BasesException
{
    public class ErrorOnValidationException : CashFlowException
    {
        public List<string> Errors { get; set; }

        public ErrorOnValidationException(List<string> errors)
        {
            Errors = errors;
        }
    }
}
