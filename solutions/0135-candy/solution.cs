public class Solution {
    public int Candy(int[] ratings) {
        int[] candies = new int[ratings.Length];

        for(int j = 0;j<ratings.Length;j++){
            candies[j] = 1;
        }

        for(int i = 1;i<ratings.Length;i++){
            if(ratings[i] > ratings[i-1]){
                candies[i] = candies[i-1]+1;
            }
        }

        for(int k = ratings.Length-2;k>=0;k--){
            if(ratings[k] > ratings[k+1]){
                candies[k] = (candies[k] > candies[k+1]+1)? candies[k]:candies[k+1]+1;
            }
        }

        int cand = 0;
        foreach(int candy in candies){
            cand+=candy;
        }

        return cand;
    }
}