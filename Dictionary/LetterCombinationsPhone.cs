/*Given a string containing digits from 2-9 inclusive, return all possible letter combinations that the number could represent.*/
using System.Collections.Generic;

namespace ConsoleApp1
{
    class LetterCombinationsPhone
    {
        public static IList<string> LetterCombinations(string digits)
        {
            Dictionary<char, List<char>> dictionary = new Dictionary<char, List<char>>();

            dictionary.Add('2', new List<char>() { 'a', 'b', 'c' });
            dictionary.Add('3', new List<char>() { 'd', 'e', 'f' });
            dictionary.Add('4', new List<char>() { 'g', 'h', 'i' });
            dictionary.Add('5', new List<char>() { 'j', 'k', 'l' });
            dictionary.Add('6', new List<char>() { 'm', 'n', 'o' });
            dictionary.Add('7', new List<char>() { 'p', 'q', 'r', 's' });
            dictionary.Add('8', new List<char>() { 't', 'u', 'v' });
            dictionary.Add('9', new List<char>() { 'w', 'x', 'y', 'z' });

            var final = new List<string>();
            final.Add("");
            foreach(var s in digits)
            {
                var result = new List<string>();
                var alphabets = dictionary[s];

                foreach (var r in final)
                    foreach (var c in alphabets)
                        result.Add(r + c);

                final = result;
            }

            return final;
        }
    }
}
