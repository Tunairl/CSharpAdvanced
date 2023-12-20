namespace System // extensionmethods could be in the System namespace
{ // MSDN says create Extension Methods ONLY when it's REALLY necessary
    public static class StringExtensions
    { 
        // the extended methods should be PUBLIC STATIC
        public static string Shorten(this String str, int numberOfWords)
        {
            if (numberOfWords <= 0)
            {
                throw new ArgumentOutOfRangeException("numberOfWords should be greater than 0.");
            }

            var words = str.Split(' ');
            if (words.Length <= numberOfWords) 
            {
                return str;
            }

            return string.Join(" ", words.Take(numberOfWords)) + "...";
        }
    }
}