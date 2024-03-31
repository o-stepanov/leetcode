public class Solution 
{
    public bool CanConstruct(string ransomNote, string magazine) 
    {
        var d1 = new Dictionary<char, int>(ransomNote.Length);
        var d2 = new Dictionary<char, int>(magazine.Length);

        foreach(var c in ransomNote.ToArray())
        {
            d1[c] = !d1.ContainsKey(c)? 1 : d1[c]+1;            
        }

        foreach(var c in magazine.ToArray())
        {
            d2[c] = !d2.ContainsKey(c)? 1 : d2[c]+1;            
        }

        foreach(var item in d1)
        {
            if(!d2.ContainsKey(item.Key))
                return false;
            
            if(d2[item.Key]<item.Value)
                return false;
        }

        return true;
    }
}