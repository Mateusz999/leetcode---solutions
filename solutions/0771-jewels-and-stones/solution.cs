public class Solution {
    public int NumJewelsInStones(string jewels, string stones) {
        int counter  = 0;

        foreach(char stone in stones){
            if(jewels.Contains(stone)) counter++;
        }

        return counter;
    }
}