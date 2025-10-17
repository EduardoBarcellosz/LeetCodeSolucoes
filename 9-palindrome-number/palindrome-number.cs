public class Solution {
    public bool IsPalindrome(int x) {
        if(x < 0)
            return false;
        
        string invertido = string.Concat(x.ToString().Reverse());
        if(invertido == x.ToString())
        {
            return true;
        }
        return false;
    }
}