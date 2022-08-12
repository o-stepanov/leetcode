public class Solution {
    public bool IsPalindrome(int x) {
        var strX = x.ToString();
        var xA1 = strX.ToArray();
        var xA2 = xA1.Reverse().ToArray();
        
        for(int i=0; i<xA2.Length; i++)
        {
            if(xA2[i]!=xA1[i])
            {
                return false;
            }
        }
        
        return true;
    }
}