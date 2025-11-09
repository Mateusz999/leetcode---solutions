public class Solution {
    public int[] MinOperations(string boxes) {
        int[] operationCounter = new int[boxes.Length];

        for(int i =0;i<boxes.Length;i++){
            for(int j =0;j<boxes.Length;j++){
                int tempElement = Convert.ToInt32(new string(boxes[j], 1));
                if(tempElement == 1){
                    operationCounter[i] += Math.Abs(i-j);
                }
            }
        }

        return operationCounter;
    }
}