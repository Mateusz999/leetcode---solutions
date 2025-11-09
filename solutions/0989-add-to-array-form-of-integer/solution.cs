public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
        IList<int> res = new List<int>();
        string number = String.Join("",num);
        BigInteger resNumber = BigInteger.Parse(number);
        resNumber+=k;
        number = resNumber.ToString();
        foreach(char letter in number){
            res.Add(letter-'0');
        }
        return res;
    }
}