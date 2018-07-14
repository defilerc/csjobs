using System.Collections.Generic;

namespace CodeFights
{
    public class RansomNote
    {
        public static bool checkMagazine(string[] magazine, string[] note) {
            
            var magazineWords = new Dictionary<string, int>();

            foreach (var m in magazine) {
                if (!magazineWords.ContainsKey(m)) {
                    magazineWords.Add(m, 1);
                } else {
                    magazineWords[m]++;
                }
            }

            foreach (var n in note) {
                if (!magazineWords.ContainsKey(n) ||
                  magazineWords[n] == 0) {
                    return false;
                }
                magazineWords[n]--;
            }

            return true;
        }
    }
}