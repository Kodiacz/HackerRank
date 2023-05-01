using System.Collections.Immutable;
using System.Text;

namespace DictionariesAndHashmaps
{
    public class SherlockAndAnagrams
    {
        private int SherlockAndAnagramsResult(string s)
        {
            var hash = new Dictionary<string, int>();
            var result = 0;

            for (int i = 0; i < s.Length - 1; i++)
            {
                for (int k = 0; k < s.Length - i; k++)
                {
                    var charsArray = s.Substring(k, i + 1).ToArray();
                    Array.Sort(charsArray);
                    var substring = new string(charsArray);

                    if (!hash.ContainsKey(substring))
                    {
                        hash.Add(substring, 1);
                    }
                    else
                    {
                        hash[substring]++;
                    }
                }
            }

            foreach (var key in hash.Keys)
            {
                int v = hash[key];
                result += (v * (v - 1)) / 2;
            }


            return result;
        }

        public static void Run()
        {
            var sherlockAndAnagrams = new SherlockAndAnagrams();

            //var result = sherlockAndAnagrams.SherlockAndAnagramsResult("abba");
            //Console.WriteLine(result);
            //var result1 = sherlockAndAnagrams.SherlockAndAnagramsResult("abcd");
            //Console.WriteLine(result1);
            //var result2 = sherlockAndAnagrams.SherlockAndAnagramsResult("ifailuhkqq");
            //Console.WriteLine(result2);
            var result3 = sherlockAndAnagrams.SherlockAndAnagramsResult("kkkkkkkkk");
            Console.WriteLine(result3);
            //var result4 = sherlockAndAnagrams.SherlockAndAnagramsResult("cdcd");
            //Console.WriteLine(result4);
            //var result5 = sherlockAndAnagrams.SherlockAndAnagramsResult("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa");
            var result5 = sherlockAndAnagrams.SherlockAndAnagramsResult("gffryqktmwocejbxfidpjfgrrkpowoxwggxaknmltjcpazgtnakcfcogzatyskqjyorcftwxjrtgayvllutrjxpbzggjxbmxpnde");
            Console.WriteLine(result5);

        }
    }
}

// 9 kkkkkkkkk = 36
// 8 kkkkkkkk = 28
// 7 kkkkkkk = 21
// 6 kkkkkk = 15 = 23
// 5 kkkkk = 10 = 16
// 4 kkkk = 6 = 10
// 3 kkk = 3 = 4
// 2 kk = 1 = 1
// 1 k = 0