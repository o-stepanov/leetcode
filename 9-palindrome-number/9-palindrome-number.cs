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
        
        int revertX = 0;
        while(x > revertX) {
            revertX = revertX * 10 + x % 10;
            x /= 10;
        }
        
        return x == revertX || x == revertX/10;
    }
}