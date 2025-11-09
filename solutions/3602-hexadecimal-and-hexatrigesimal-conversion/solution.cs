public class Solution {
    private string _digits = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    
    public string ConcatHex36(int n) =>
        SHexadecimal(n*n, 16) + SHexadecimal(n*n*n, 36);

    public string SHexadecimal(int n, int hex){
        if(n==0) return "0";
        StringBuilder ret = new StringBuilder();
        while(n>0){
            int i = n % hex;
            ret.Insert(0,_digits[i]);
            n /= hex;
        }
        return ret.ToString();
    }
}