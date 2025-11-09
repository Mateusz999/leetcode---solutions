public class Solution {
    public int HeightChecker(int[] heights) {
        int[] expected = new int[heights.Length];
        Array.Copy(heights,expected,heights.Length);
        Array.Sort(expected);
        int counter = 0;

        for(int j = 0;j<heights.Length;j++){
            if(heights[j] != expected[j]) counter++;
        }
        return counter;




    }
}