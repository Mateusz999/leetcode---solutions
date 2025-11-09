public class Solution {
    public string ToHex(int num) {
        bool isNegative = false;
        if(num<0)isNegative = true;
        return num.ToString("x");
    }
}