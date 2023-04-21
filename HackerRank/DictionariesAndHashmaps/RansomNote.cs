using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;

namespace DictionariesAndHashmaps
{
    public class RansomNote
    {
        private string CheckMagazine(List<string> magazine, List<string> note)
        {
            //Dictionary<string, int> noteWords = new Dictionary<string, int>();
            //Dictionary<string, int> magazineWords = new Dictionary<string, int>();

            //foreach (string word in note)
            //{
            //    if (!noteWords.ContainsKey(word))
            //    {
            //        noteWords.Add(word, 1);
            //        continue;
            //    }

            //    noteWords[word]++;
            //}

            //foreach (string word in magazine)
            //{
            //    if (!magazineWords.ContainsKey(word))
            //    {
            //        magazineWords.Add(word, 1);
            //        continue;
            //    }

            //    magazineWords[word]++;
            //}

            //foreach (var word in noteWords)
            //{
            //    if (!magazineWords.ContainsKey(word.Key))
            //    {
            //        return "No";
            //    }
            //    else if (magazineWords[word.Key] < word.Value)
            //    {
            //        return "No";
            //    }
            //}

            //return "Yes";

            Dictionary<string, int> hash = new Dictionary<string, int>();

            foreach (var word in magazine)
            {
                if (hash.ContainsKey(word))
                {
                    hash[word]++;
                }
                else
                {
                    hash.Add(word, 1);
                }
            }

            foreach (var c in note)
            {
                if (hash.ContainsKey(c) && hash[c] > 0)
                {
                    hash[c]--;
                }
                else
                {
                    return "No";
                }
            }

            return "Yes";
        }



        public static void Result()
        {
            RansomNote ransomeNote = new RansomNote();

            var magazine = new List<List<string>>()
            {
                "give me one grand today night".Split(' ').ToList(),
                "two times three is not four".Split(' ').ToList(),
                "ive got a lovely bunch of coconuts".Split(' ').ToList(),
            };

            var notes = new List<List<string>>()
            {
                "give one grand today".Split(' ').ToList(),
                "two times two is four".Split(' ').ToList(),
                "ive got some coconuts".Split(' ').ToList(),
            };

            var result0 = ransomeNote.CheckMagazine(magazine[0], notes[0]);
            Console.WriteLine(result0);

            var result1 = ransomeNote.CheckMagazine(magazine[1], notes[1]);
            Console.WriteLine(result1);

            var result2 = ransomeNote.CheckMagazine(magazine[2], notes[2]);
            Console.WriteLine(result2);

        }
    }
}

/*
Examples:

6 4
give me one grand today night
give one grand today

Yes

===========================================

6 5
two times three is not four
two times two is four

No  

===========================================

7 4
ive got a lovely bunch of coconuts
ive got some coconuts

No
*/