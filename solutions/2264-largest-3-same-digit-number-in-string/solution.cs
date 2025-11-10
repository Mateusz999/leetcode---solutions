public class Solution {
    public string LargestGoodInteger(string num) {
        int max = -100;
        bool tag = false;
        if(num.Length == 3){
            if(num[0] == num[1]  && num[0] == num[2]) {
                string charResult = ""+num[0] + num[1] + num[2];
                return charResult;
            } 
            else return "";
        }
        for(int i = 0; i<num.Length-2;i++){

            if(num[i] == num[i+1] && num[i] == num[i+2]){
            string charResult = ""+num[i] + num[i+1] + num[i+2];
            int res = Convert.ToInt32(charResult);
            max = (max < res)?  res : max;
            tag = true;
            }
        }
        if(max == 0 ) return "000";
        return  tag? max.ToString() : "";
    }
}