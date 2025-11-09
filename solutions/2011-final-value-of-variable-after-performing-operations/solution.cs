public class Solution {
    public int FinalValueAfterOperations(string[] operations) {
        int counter = 0;

        foreach(string operation in operations){
            if(operation.Contains("--")) counter--;
            else counter++;
        }
        return counter;
    }
}