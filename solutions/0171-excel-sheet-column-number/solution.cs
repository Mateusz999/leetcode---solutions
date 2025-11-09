public class Solution {
    public int TitleToNumber(string columnTitle) {
        int titleValue = 0;
        for(int i = 0;i<columnTitle.Length;i++){
           
           titleValue+= (((int)(columnTitle[i])-64)*((int)Math.Pow(26,columnTitle.Length-i-1)));
        }
        return titleValue;
    }
}