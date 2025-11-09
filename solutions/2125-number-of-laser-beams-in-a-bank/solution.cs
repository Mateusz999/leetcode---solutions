public class Solution {
    public int NumberOfBeams(string[] bank) {
        int[] laserCounter = new int [bank.Length];
        int laserAmount = 0;
        for(int i = 0; i < bank.Length;i++){
            for(int j = 0; j < bank[i].Length;j++){
                if(bank[i][j] =='1'){
                    laserCounter[i]+=1;
                }
            }
        }
        int prev = 0;
        for (int i = 0; i < laserCounter.Length; i++) {
            if (laserCounter[i] > 0) {
                laserAmount += prev * laserCounter[i];
                prev = laserCounter[i];
            }
        }
        return laserAmount;
    }
}