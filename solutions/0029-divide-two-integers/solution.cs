public class Solution {
    public int Divide(int dividend, int divisor) {
        if (dividend == int.MinValue && divisor == -1)
            return int.MaxValue; // przepełnienie
        
        // Znak wyniku
        bool negative = (dividend < 0) ^ (divisor < 0);

        long dividend_ = Math.Abs((long)dividend);
        long divisor_ = Math.Abs((long)divisor);

        int result = 0;

        while (dividend_ >= divisor_) {
            long temp = divisor_;
            int multiple = 1;

            // Szukaj największej wielokrotności
            while (dividend_ >= (temp << 1)) {
                temp <<= 1;
                multiple <<= 1;
            }

            dividend_ -= temp;
            result += multiple;
        }

        return negative ? -result : result;
    }
}
