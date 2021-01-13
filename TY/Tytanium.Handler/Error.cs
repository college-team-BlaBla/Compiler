namespace Handler
{
    public class Error
    {
        public enum ErrorType
        {
            ScannerError,
            ParserError,
            SynthesisFailure
        }

        public string ErrorMassege;
        public ErrorType Type;

        public Error(string msg, ErrorType ET)
        {
            ErrorMassege = msg;
            Type = ET;
        }

    }
}
