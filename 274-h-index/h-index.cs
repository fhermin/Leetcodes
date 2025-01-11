public class Solution {
        public int HIndex(int[] citations)
        {
            int count = 0;
            Array.Sort(citations);
            Array.Reverse(citations);
           
            for (int i=0; i<citations.Length; i++)
            {
                if(citations[i] >= i+1)
                    {
                        count++;
                    }
            }
            return count;
        }
}