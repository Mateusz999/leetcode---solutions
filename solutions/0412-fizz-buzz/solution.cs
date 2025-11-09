public class Solution {
    public IList<string> FizzBuzz(int n) {
        IList<string> buzzArr = new List<string> ();
        for(int i= 1; i <= n; i++){
            if(i % 3 == 0 && i % 5 != 0) buzzArr.Add("Fizz");
            else if(i % 5 == 0 && i % 3 != 0)buzzArr.Add("Buzz");
            else if(i % 15 == 0 ) buzzArr.Add("FizzBuzz");
            else buzzArr.Add($"{i}");
        }
        return buzzArr;
    }
}