public class Solution {
    public string ConvertDateToBinary(string date) {
        string[]els =  date.Split("-");
        string result = "";
     
        for(int i =0 ; i<els.Length;i++){
            int podstawa = int.Parse(els[i]); 
            result +=Convert.ToString(podstawa, 2);
             if(i<els.Length-1 ) result +="-";
        }
    
        return result;
    }
}