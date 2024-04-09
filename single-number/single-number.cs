public class Solution 
{
    public int SingleNumber(int[] nums) 
    {
        if(nums.Length==1)
            return nums[0];
        
        var d = new Dictionary<int, int>(nums.Length);
        
        foreach(var n in nums)
        {
            if(d.ContainsKey(n))
                d[n]+=1;
            else
                d.Add(n, 1);
        }
                
        return d.First(x=>x.Value==1).Key;
    }
}