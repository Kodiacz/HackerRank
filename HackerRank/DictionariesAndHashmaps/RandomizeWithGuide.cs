namespace DictionariesAndHashmaps
{
    public class RandomizeWithGuide
    {
        static public void OneLine(List<int> list)
        {
            var shuffledcards = list.OrderBy(a => Guid.NewGuid()).ToList();
            //var shuffledcards = list.OrderBy(a => Guid.NewGuid()).ToList();
            Console.WriteLine(string.Join(' ', shuffledcards));
        }
    }
}
