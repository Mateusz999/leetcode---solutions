public class Solution {
    public char FindTheDifference(string s, string t) {
  int temp = 0;
        foreach(var cp in s+t){
            temp ^= cp;
        }
        return (char)temp;
}
}