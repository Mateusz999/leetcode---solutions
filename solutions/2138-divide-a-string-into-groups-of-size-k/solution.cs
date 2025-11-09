public class Solution {
    public string[] DivideString(string s, int k, char fill) {
        List<string> res = new List<string>();
        int cnt = 0;
        string resultString = "";
        foreach(char l in s ){
            resultString += l;
            cnt++;

            if(cnt == k){
                res.Add(resultString);
                resultString = "";
                cnt = 0;
            }
        }
            if(cnt > 0){
                while(cnt < k){
                    resultString+= fill;
                    cnt++;
                }

                res.Add(resultString);
            }

            return res.ToArray();
        }
}