public class Solution {
        public int LengthOfLastWord(string s)
        {
            int a = s.Length-1;
            int aux = 0;
            while(0<=a)
            {
                if (s[a] == ' ' && aux > 0) break;
                else if (s[a] != ' ') aux++;
                a--;
            }
            return aux;
        }
}