public class Solution {
    public int FinalPositionOfSnake(int n, IList<string> commands) {
        int x = 0,y=0;
        int size = commands.Count;
        foreach (string command in commands)
        {
            if(command == "UP") {
                if(y > 0) y--;
            }
            else if(command =="RIGHT"){
                if(x<n-1) x++;
            }
            else if(command =="DOWN"){
                if(y<n-1) y++;
            }
            else if(command =="LEFT"){
                if(x > 0) x--;
            }
        }
        return y*n+x;
    }
}