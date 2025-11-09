public class Solution {
    public int CountMatches(IList<IList<string>> items, string ruleKey, string ruleValue) {
        int key = 0;

        switch(ruleKey)
        {
            case("type"):
            key = 0;
            break;

            case("color"):
            key = 1;
            break;

            case("name"):
            key = 2;
            break;
        }

        int result = 0;

        for(int i = 0;i<items.Count;i++)
        {
            for(int j =0;j<items[i].Count;j++)
            {
                if(items[i][j] == ruleValue & j == key)
                {
                    result++;
                    break;
                }
            }
        }
        return result; 
    }
}