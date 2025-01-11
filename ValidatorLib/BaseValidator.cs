namespace ValidatorLib
{
    public static class BaseValidator
    {
        public static bool LengthValidator(string word, int min = 10, int max = 10)
        {
            int length = word.Length;
            return length >= min && length <= max;
        }

        public static bool ContainNumberValidator(string word)
        {
            return word.Any(char.IsDigit);
        }
        public static bool ContainLetterValidator(string word)
        {
            return word.Any(char.IsLetter);
        }
        public static bool ContainMarkValidator(string word)
        {
            return word.Any(ch => !char.IsLetterOrDigit(ch));
        }

        public static bool ContainWhiteSpaceValidator(string word)
        {
            return word.Any(char.IsWhiteSpace);
        }
    }
}
