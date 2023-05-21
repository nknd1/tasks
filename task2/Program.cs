class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        string[] words = input.Split(' ');

        Dictionary<string, int> wordFreq = new Dictionary<string, int>();

        foreach (string word in words)
        {
            if (wordFreq.ContainsKey(word))
            {
                wordFreq[word]++;
            }
            else
            {
                wordFreq[word] = 1;
            }
        }

        var sortedWords = wordFreq.OrderBy(pair => pair.Value);

        int maxFreq = sortedWords.Last().Value;

        int maxWordLength = sortedWords.Last().Key.Length;

        foreach (var pair in sortedWords)
        {
            string word = pair.Key;
            int freq = pair.Value;
            int numDots = (int)Math.Round((double)freq / maxFreq * 10);
            Console.Write(word.PadLeft(maxWordLength, '_') + "");
            Console.WriteLine(new string('.', numDots));
        }
        
    }
}