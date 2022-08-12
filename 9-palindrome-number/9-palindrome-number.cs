public class Solution {
    public bool IsPalindrome(int x) {
        var strX = x.ToString();
        var strReverseX = new string(strX.Reverse().ToArray());
        return strX==strReverseX;
    }
}