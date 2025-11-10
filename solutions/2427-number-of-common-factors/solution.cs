public class Solution {
    public int CommonFactors(int a, int b) {
        int max = 0;
        int counter = 0;
        if(a > b) max = a;
        else max =b;
        for(int i = 1;i<=max;i++){
            if(a% i == 0 && b % i == 0) counter++;
        }
        return counter;
    }
}