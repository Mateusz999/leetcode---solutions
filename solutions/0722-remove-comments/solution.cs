public class Solution {
    public IList<string> RemoveComments(string[] source) {
        List<string> res = new List<string>();
        bool IsThereComment = false;
        StringBuilder newLine = new();
        foreach(var line in source){
            int n = line.Length, i = 0;
            while(i < line.Length){
                // ignore single comment in case there comment before
                if(!IsThereComment && i + 1 < n && line[i] == '/' && line[i] == line[i + 1])
                    break;
                // open multiple comment && if there no comment
                if(!IsThereComment && i + 1 < n && line[i] == '/' && line[i + 1] == '*'){
                    i+= 2;
                    IsThereComment = true;
                    continue;
                }
  
                // close comment if there one opened before
                if(IsThereComment && i + 1 < n && line[i] == '*' && line[i + 1] == '/'){
                    IsThereComment = false;
                    i+=2;
                    continue;
                }

                if(!IsThereComment)
                    newLine.Append(line[i]);
                i++;
            }
            string str = newLine.ToString();
            if(str.Length > 0 && !IsThereComment){
                res.Add(str);
                newLine.Clear();
            }
        }
        return res;
    }
}