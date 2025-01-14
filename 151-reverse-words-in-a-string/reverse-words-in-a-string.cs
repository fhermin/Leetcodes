public class Solution {
        public string ReverseWords(string s)
        {
            // Divide la cadena en palabras usando el espacio como delimitador
            string[] words = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            
            Array.Reverse(words);

            // Une las palabras con un espacio entre ellas
            return string.Join(" ", words);
        }
}