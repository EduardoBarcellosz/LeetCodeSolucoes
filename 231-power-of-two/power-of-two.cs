public class Solution {
    public bool IsPowerOfTwo(int n) {
        for (int k = 0; k < 31; k++) {
            if (Math.Pow(2,k) == n)
                return true;
        }
        return false;
    }
}