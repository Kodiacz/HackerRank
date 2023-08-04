namespace DictionariesAndHashmaps
{
    public class CountTriplets
    {
        private long CountTripletsResult(List<long> arr, long r)
        {
            var dictionary = new Dictionary<string, int>();
            var dictionary2 = new Dictionary<string, int>();

            for (var i = 0; i < arr.Count - 2; i++)
            {
                for (var j = i; j < arr.Count - 2; j++)
                {
                    var key = arr[i].ToString() + "-" + arr[i + 1].ToString() + "-" + arr[j + 2].ToString();
                    var key2 = i + "-" + (i + 1) + "-" + (j + 2);

                    if (!dictionary.ContainsKey(key))
                    {
                        dictionary.Add(key, 1);
                    }
                    else
                    {
                        dictionary[key]++;
                    }

                    if (!dictionary2.ContainsKey(key2))
                    {
                        dictionary2.Add(key2, 1);
                    }
                    else
                    {
                        dictionary2[key2]++;
                    }
                }
            }

            return default(long);
        }

        public static void Run()
        {
            var countTriplets = new CountTriplets();

            var test1 = new List<long> { 1, 3, 9, 9, 27, 81 };

            var result = countTriplets.CountTripletsResult(test1, 3);
        }
    }
}

/*
1, 4, 16, 64
1, 2, 2, 4
1, 3, 9, 9, 27, 81
1, 5, 5, 25, 125
*/

// i == 1 && j == 2