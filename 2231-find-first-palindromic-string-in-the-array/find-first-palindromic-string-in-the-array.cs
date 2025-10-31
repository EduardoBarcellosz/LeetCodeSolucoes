public class Solution {
    public string FirstPalindrome(string[] words) {
        foreach(string word in words){
            string invertida = new string(word.Reverse().ToArray());
            if(invertida == word)
                return word;
        }
        return "";
    }
}