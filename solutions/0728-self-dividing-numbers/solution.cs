public class Solution {
    public IList<int> SelfDividingNumbers(int left, int right) {
        IList<int> rest = new List<int>();
        for(int i = left;i<=right;i++){
            string temp = i.ToString();
            bool tag = true;
            if(temp.Contains('0')) continue;
            foreach(char l in temp){
                if(i % (l-'0') !=0){
                     tag= false;
                     break;
                }
            }
            if(tag == true) rest.Add(i);
        }

        return rest.ToArray();
    }
}