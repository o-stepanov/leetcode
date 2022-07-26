public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        if(nums == null || nums.Length==0)
        {
          return null;  
        }
        
        for(int i=0; i<nums.Length; i++)
        {
            var t1 = target-nums[i];
            for(int j=i+1; j<nums.Length; j++)
            {                
                if(t1==nums[j])
                {
                    return new [] {i, j};
                }
            }
        }
        
        return null;
    }
}