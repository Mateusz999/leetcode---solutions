public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        int len = flowerbed.Length;

        for (int i = 0; i < len && n > 0; i++) {
            if (flowerbed[i] == 0 &&
                (i == 0 || flowerbed[i - 1] == 0) &&
                (i == len - 1 || flowerbed[i + 1] == 0)) {
                    
                flowerbed[i] = 1; 
                n--;              
                i++;             
            }
        }

        return n == 0;
    }
}
