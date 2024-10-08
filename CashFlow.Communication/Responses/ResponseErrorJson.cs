namespace CashFlow.Communication.Responses
{
    public class ResponseErrorJson
    {
        public List<string> ErrorMessage { get; set; }

        public ResponseErrorJson(List<string> errorsMessage) 
        { 
            ErrorMessage = errorsMessage;
        }

        public ResponseErrorJson(string errorMessage)
        {
            ErrorMessage = [errorMessage];
        }
    }
}
