namespace Core.Models.Exception
{
    public class ErrorHandled : IOException
    {
        public string Message { get; set; }

        public ErrorHandled(string message)
        {
            Message = message;
        }
    }
}
