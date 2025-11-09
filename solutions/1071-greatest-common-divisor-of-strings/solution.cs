public class Solution {
    public string GcdOfStrings(string str1, string str2) {
        if( str1 + str2 != str2 + str1 ) return "";
        
        int GDCLength = GDC(str1.Length, str2.Length);

        return str1.Substring(0,GDCLength);
    }

    private int GDC(int a, int b ){
        while(b != 0){
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}