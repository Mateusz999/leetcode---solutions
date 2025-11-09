public class Solution {
    public int NumTilings(int n) {
        long modulos = 1000000007;
        long[] solutionArray = new long[1001];
        
        solutionArray[1] = 1;
        solutionArray[2] = 2;
        solutionArray[3] = 5;

        for(int i = 4;i<=n;i++){
            solutionArray[i] = (2*solutionArray[i-1] + solutionArray[i-3]) % modulos;
        }
        return Convert.ToInt32(solutionArray[n]);

    }
}