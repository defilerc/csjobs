using System;

namespace CodeFights
{
    public class ZigZagAlgo
    {
        public int ZigZag(int[] a) 
        {
            var max = 1;

            for (var i = 1; i < a.Length; i++) {
                var length = MaxZigZagLength(a, i);

                max = Math.Max(max, length);
            }

            return max;
        }

        private int MaxZigZagLength(int[] a, int start)
        {
            if (a[start] == a[start - 1]) {
                return 1;
            }

            if (start >= a.Length) {
                return 2;
            }

            var length = 2;
            var greater = a[start] > a[start - 1];

            for (var i = start + 1; i < a.Length; i++) {
                
                if (greater && a[i] < a[i-1]) {
                    length++;
                    greater = !greater;
                } else if (!greater && a[i] > a[i-1]) {
                    length++;
                    greater = !greater;
                } else {
                    return length;
                }
            }

            return length;
        }
    }    
}
