public class Solution {
 public string ConvertToTitle(int columnNumber)
{
    string result = "";
    while (columnNumber > 0)
    {
        columnNumber--; 
        char c = (char)('A' + (columnNumber % 26));
        result = c + result;
        columnNumber /= 26;
    }
    return result;
}
}