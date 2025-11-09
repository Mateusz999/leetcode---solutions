public class Solution {
    public int EarliestFinishTime(int[] landStartTime, int[] landDuration, int[] waterStartTime, int[] waterDuration) {
        int res = int.MaxValue;

        for(int i = 0 ; i <landStartTime.Length;i++){
            for(int j = 0;j<waterStartTime.Length; j++ ){
                int ladkoniec = landStartTime[i] + landDuration[i];
                int wodnaPoLadowej = Math.Max(waterStartTime[j], ladkoniec);
                int planA = wodnaPoLadowej + waterDuration[j];
                res = Math.Min(res, planA);

                int wodnakoniec = waterStartTime[j] + waterDuration[j];
                int ladownaPoWodnej = Math.Max(landStartTime[i], wodnakoniec);
                int planB = ladownaPoWodnej + landDuration[i];
                res = Math.Min(res, planB);
            }
        }
        return res;
        
    }
}