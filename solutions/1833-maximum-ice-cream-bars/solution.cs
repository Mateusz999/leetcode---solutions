public class Solution {
    public int MaxIceCream(int[] costs, int coins) {
        int[] countingSort = new int[100001];

        foreach(int cost in costs){
            countingSort[cost]++;
        }
        int idx= 1;
        int amount = 0;
        for(int i = 0;i<countingSort.Length;i++){
            for(int k = 0;k<countingSort[i];k++){
                if(coins > 0){
                    coins-=i;
                    if(coins >= 0)amount++;
                }else return amount;
            }
        }
        return amount;
    }
}