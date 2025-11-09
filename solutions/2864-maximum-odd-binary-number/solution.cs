public class Solution {
    public string MaximumOddBinaryNumber(string s) {
        int n = s.Length;
        int zeros = 0;
        int ones = 0;
        int i = 0;
        foreach(char ch in s ){
            if(ch == '1') ones++;
            else zeros++;
        }

        char[] result = new char[s.Length];
        while(i<ones-1){
            result[i++] = '1';
        }
          while(i<ones-1 + zeros){
            result[i++] = '0';
        }
        result[i] = '1';

        return new string(result);
    }
}