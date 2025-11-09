public class Solution {
    public int SumOfTheDigitsOfHarshadNumber(int x) {
        string divider = x.ToString();
        int dividerNum = 0;
        foreach(char d in divider){
            dividerNum+=d-'0';

        }

        return (x%dividerNum == 0)? dividerNum : -1;
    }
}