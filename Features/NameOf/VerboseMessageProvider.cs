namespace Features.NameOf
{
    public static class VerboseMessageProvider
    {
        public static string GetMessageWithDetailsOfImplementation(string passedMessage)
        {
            var nameOfParameter = nameof(passedMessage);
            return $"Value of {nameOfParameter} passed to the method was {passedMessage}";
        }
    }
}
