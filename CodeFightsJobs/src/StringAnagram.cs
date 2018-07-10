using System;
using System.Collections.Generic;

namespace CodeFights
{
    public class StringAnagram
    {
        public int MakeAnagram(string a, string b) 
        {
            var aDict = new Dictionary<char, int>();
            var bDict = new Dictionary<char, int>();

            foreach (var c in a.ToCharArray()) {
                if (!aDict.ContainsKey(c)) {
                    aDict.Add(c, 1);
                } else {
                    aDict[c]++;
                }
            }

            foreach (var c in b.ToCharArray()) {
                if (!bDict.ContainsKey(c)) {
                    bDict.Add(c, 1);
                } else {
                    bDict[c]++;
                }
            }

            var removals = 0;

            for (var c = 'a'; c <= 'z'; c++) {
                var aFreq = aDict.ContainsKey(c) ? aDict[(char)c] : 0;
                var bFreq = bDict.ContainsKey(c) ? bDict[(char)c] : 0;

                removals += Math.Abs(aFreq - bFreq);
            }

            return removals;
        }
    }
}