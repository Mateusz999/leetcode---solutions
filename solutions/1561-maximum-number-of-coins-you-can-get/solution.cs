public class Solution {
    public int MaxCoins(int[] piles) {
        int turn = piles.Length /3, ans = 0;

        Array.Sort(piles);

        for(int i = piles.Length -2; turn>0;i-=2){
            ans+= piles[i];
            turn--;
        }

        return ans;
    }
}