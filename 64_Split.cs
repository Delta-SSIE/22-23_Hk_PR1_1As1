namespace _64_Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string phrase = "The quick brown,fox jumps:over the lazy dog.";
            char[] oddelovac = { ' ', ',', ':' };
            string[] words = phrase.Split(oddelovac);

            foreach (var word in words)
            {
               Console.WriteLine($"<{word}>");
            }
        }
    }
}
