namespace DictionariesAndHashmaps
{
    public class TwoStrings
    {
        private string TwoStringsResult(string s1, string s2)
        {
            var hashS1 = new HashSet<char>();
            var hashS2 = new HashSet<char>();

            for (int i = 0; i < s1.Length - 1; i++)
            {
                hashS1.Add(s1[i]);
            }

            for (int i = 0; i < s2.Length; i++)
            {
                hashS2.Add(s2[i]);
            }

            bool check = false;

            foreach (char c in hashS1)
            {
                if (hashS2.Contains(c))
                {
                    check = true;
                }
            }

            return check ? "YES" : "NO";
        }

        public static void Run()
        {
            TwoStrings twoStrings = new TwoStrings();

            var result = twoStrings.TwoStringsResult("hello", "world");
            var result1 = twoStrings.TwoStringsResult("hi", "world");

            Console.WriteLine(result);
            Console.WriteLine(result1);

        }
    }
}
