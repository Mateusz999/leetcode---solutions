public class Solution {
    public int[] CountPoints(int[][] points, int[][] queries) {
        int m = queries.Length;
        int n = queries[0].Length;
        int cnt = 0;
        int[] counter = new int [queries.Length];
        for(int i = 0 ;i <m;i++){
           var query = queries[i];
            cnt = 0;
           foreach(var point in points){
                int x = (point[0]-query[0]) * (point[0]-query[0]);
                int y = (point[1]-query[1]) * (point[1]-query[1]);
                if(x+y <= query[2]*query[2]) cnt++;
           }
           counter[i] = cnt;
        }
        return counter;
    }
}