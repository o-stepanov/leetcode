public class Solution {
    public bool IsPalindrome(int x) {
        if(x<0 || (x%10==0 && x!=0))
        {
            return false;
        }
        
        if(x>=0 && x<10)
        {
            return true;
        }
        
        var strX = x.ToString();
        var xA1 = strX.ToArray();
        var xA2 = xA1.Reverse().ToArray();
        
        return xA2.SequenceEqual(xA1);
    }
}