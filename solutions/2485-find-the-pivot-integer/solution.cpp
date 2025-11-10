class Solution {
public:
    int pivotInteger(int n) {
        /*
        Przyklad:
        1. 8 => suma = 72/2 = 36
        a = 6
        2. 4 => suma = 10
        a = sqrt(10);
        */
        int suma = n * ( n + 1 ) / 2; 
        double a = sqrt( suma );

        if( a - ceil( a ) == 0 ) return int(a);
        else return -1;
    }
};