class Program
{
    static void Main()
    {
        var sentence = "This is a really really really really really really long semtence";
    
        Console.WriteLine(SummarizeText(sentence,20));
        

    }
    static string SummarizeText(String text, int maxLength = 20)
    {

        if (text.Length < maxLength)
            return text;
        else
        {
            var words = text.Split(' ');
            var totalCharacter = 0;
            var summaryWords = new List<string>();

            foreach (var word in words)
            {
                summaryWords.Add(word);

                totalCharacter += word.Length + 1;
                if (totalCharacter > maxLength)
                    break;
            }

            return String.Join(" ", summaryWords) + "...";

        }
    }
}