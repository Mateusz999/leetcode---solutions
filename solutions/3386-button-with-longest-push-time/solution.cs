public class Solution {
    public int ButtonWithLongestTime(int[][] events) {
       int[] longest = new int[] { 0, 0 };
int current = 0;

for (int i = 0; i < events.Length; i++) {
    int duration = events[i][1] - current;

    if (duration > longest[1] || (duration == longest[1] && events[i][0] < longest[0])) {
        longest[0] = events[i][0];  
        longest[1] = duration;      
    }

    current = events[i][1];
}
return longest[0];
    }
}