public class Solution {
    public int FindClosest(int x, int y, int z) {
        int one = Math.Abs(x-z); 
        int two = Math.Abs(y-z);
        if(one == two){
            return 0;
        }
        return one > two ? 2 : 1; 
    }
}