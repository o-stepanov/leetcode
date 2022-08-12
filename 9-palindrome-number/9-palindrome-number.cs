public class Solution {
    public bool IsPalindrome(int x) {
        var strX = x.ToString();
        var xA1 = strX.ToArray();
        var xA2 = xA1.Reverse().ToArray();
        
        return xA2.SequenceEqual(xA1);
    }
}