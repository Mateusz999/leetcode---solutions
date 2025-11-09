public class Solution {
    public int HIndex(int[] citations) {
        Array.Sort(citations);
        // 0 1 3 5 6 
        // 5 4 3 2 1 
        for(int i = 0; i<citations.Length;i++){
            if(citations[i] >= citations.Length - i) return citations.Length-i;
        }

        return citations[citations.Length/2];
    }
}