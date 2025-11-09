public class Solution {
    public string Interpret(string command)
            => command.Replace("()", "o").Replace("(al)", "al");
}