namespace Features.StringInterpolation
{
    public class StringFormatter
    {
        public string FormatGreeting(string name, string day)
        {
            return $"Hello {name}, how are you this {day}?";
        }

        public string FormatFileLocationMessage(string pathLocation)
        {
            return $"The file you want is located at: {pathLocation}";
        }

        public string FormatMessageWithBrackets(string message)
        {
            return $"Your message {message}, {{these are escaped}}";
        }
    }
}
