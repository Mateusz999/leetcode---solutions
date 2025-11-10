public class Solution {
    public int Maximum69Number (int num) {
        string number = num.ToString();
        bool changed = false;
        string res = "";
        foreach(char n in number) {
            if(n =='6' && changed == false){
                res+='9';
                changed = true;
            }else {
                res+=n;
            }
        }

        return  int.Parse(res);
    }
}