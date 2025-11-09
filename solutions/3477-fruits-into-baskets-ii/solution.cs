public class Solution {
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets) {
        
        int result = 0;
        int n = baskets.Length;

        foreach(int fruit in fruits){

            int slotted = 1;

            for(int i = 0;i<n;i++){
                if(fruit <=baskets[i]){
                    baskets[i] = -1;
                    slotted = 0;
                    break;
                }
            }
            result +=slotted;
        }

        return result;
    }
}