namespace SMSApi
{
    public class SmsapiException : Exception
    {
        private int Code;

        public SmsapiException(string message, int code)
            : base(message)
        {
            Code = code;
        }

        public int GetCode()
        {
            return Code;
        }
    }
}
