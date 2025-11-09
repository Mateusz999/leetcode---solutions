public class Solution {
    public int AddDigits(int num) {

        while(Math.Abs(num).ToString().Length>1){
            int res = 0;

            string number = num.ToString();
            foreach(char n in number){
                int nu = n-'0';
                res+=nu;
            }
                num = res;

        }
        return num;
    }
}