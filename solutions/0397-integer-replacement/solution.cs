public class Solution {
    public int IntegerReplacement(int n) {
       
    long num = n; // prevent overflow
    int counter = 0;

    while (num > 1) {
        if (num % 2 == 0) {
            num /= 2;
        } else {
            if ((num == 3) || ((num - 1) % 4 == 0)) {
                num--;
            } else {
                num++;
            }
        }
        counter++;
    }

    return counter;

    }
}