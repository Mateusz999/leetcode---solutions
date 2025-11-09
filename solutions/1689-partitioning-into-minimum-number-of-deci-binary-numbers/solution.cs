public class Solution {
    public int MinPartitions(string n) {

        int max=Convert.ToInt32(n[0]-'0');
        for(int i=1;i<n.Length;i++)
        {
            if(Convert.ToInt32(n[i]-'0')>max)
            {
                max=Convert.ToInt32(n[i]-'0');
            }
        }

        return max;
        
    }
}