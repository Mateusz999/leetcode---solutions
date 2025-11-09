public class Solution {
    public int MaxSatisfaction(int[] satisfaction) {
        Array.Sort(satisfaction);

        int total =0,sum=0;

        for(int i = satisfaction.Length -1 ; i>=0;i--){
            if(total > total + sum + satisfaction[i]) break;

            sum+=satisfaction[i];
            total +=sum;
        }

        return total;

    }
}