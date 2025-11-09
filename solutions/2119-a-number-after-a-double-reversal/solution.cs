public class Solution {
    public bool IsSameAfterReversals(int num) {
        return num==0?
            true
            :
            int.Parse(string.Join
                ("",string.Join
                    ("",num.ToString()
                        .Reverse())
                            .Trim('0')
                                .Reverse())) == num;
    }
}