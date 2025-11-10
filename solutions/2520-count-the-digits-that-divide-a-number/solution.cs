public class Solution {
    public int CountDigits(int num) {
            string numStr = Math.Abs(num).ToString(); 
        int[] digits = new int[numStr.Length];  
            int counter = 0;

        for (int i = 0; i < numStr.Length; i++) {
            digits[i] = numStr[i] - '0';  
        }
            foreach(int digit in digits){
                if(num% digit == 0 && digit > 0 ) counter++;
            }
            return counter;

        }

    }
