public class Solution {
    public int Fib(int n) {
        if( n == 0 ) return 0;
      return fib(n);
    }
    private int fib (int a){
        if(a<3)
		return 1;
        return fib(a-1) + fib(a-2);
    }
}