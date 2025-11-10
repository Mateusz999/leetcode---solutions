public class Solution {
    public int FindNumbers(int[] nums) {
         int counter = 0;

         foreach(int n in nums) {
            string nLength = Convert.ToString(n);
            if(nLength.Length % 2 == 0) counter++;
         }

         return counter;   
    }
}