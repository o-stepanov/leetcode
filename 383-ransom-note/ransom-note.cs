public class Solution 
{
    public bool CanConstruct(string ransomNote, string magazine) 
    {
        var arr1 = magazine.ToArray();
        var arr2 = ransomNote.ToArray();

        Array.Sort(arr1);
        Array.Sort(arr2);

        int mIndx = 0;
        char lastLetter = arr2[0];
        for (int i = 0; i < arr2.Length; i++)
        {
            if ((i + mIndx) >= arr1.Length)
                return false;
            
            if (arr2[i] != arr1[i + mIndx])
            {
                while (mIndx < (arr1.Length - i))
                {
                    if (arr2[i] == arr1[i + mIndx])
                        break;

                    mIndx++;
                }

                if ((i + mIndx) >= arr1.Length)
                    return false;
            }
        }

        return true;




        /*var d1 = new Dictionary<char, int>(ransomNote.Length);
        var d2 = new Dictionary<char, int>(magazine.Length);

        foreach(var c in magazine.ToArray())
        {
            d2[c] = !d2.ContainsKey(c)? 1 : d2[c]+1;            
        }

        foreach(var c in ransomNote.ToArray())
        {
            if(!d2.ContainsKey(c))
                return false;

            d1[c] = !d1.ContainsKey(c)? 1 : d1[c]+1;            
        }

        foreach(var item in d1)
        {            
            if(d2[item.Key]<item.Value)
                return false;
        }*/

        return true;
    }
}