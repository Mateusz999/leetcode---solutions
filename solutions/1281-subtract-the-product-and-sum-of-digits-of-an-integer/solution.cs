public class Solution {
    public int SubtractProductAndSum(int n) {
        int addition = 0;
        int product = 1;

        string number = Convert.ToString(n);

        foreach(char digit in number){
           
            addition+=digit-'0';
            product*=digit-'0';
        }

        return product - addition;
    }
}