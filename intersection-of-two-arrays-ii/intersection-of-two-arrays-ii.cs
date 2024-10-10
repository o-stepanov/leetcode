public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        var result = new List<int>(Math.Min(nums1.Length, nums2.Length));
        var dict1 = nums1.GroupBy(x=>x).ToDictionary(x=>x.Key, v=>v.Count());
        var dict2 = nums2.GroupBy(x=>x).ToDictionary(x=>x.Key, v=>v.Count());
        foreach(var i in dict1.Keys.Intersect(dict2.Keys))
        {
            result.AddRange(Enumerable.Repeat(i, Math.Min(dict1[i], dict2[i])));
        }
        
        return result.ToArray();
    }
}