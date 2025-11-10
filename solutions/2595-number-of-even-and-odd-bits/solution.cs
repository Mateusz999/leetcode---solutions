public class Solution {
    public int[] EvenOddBit(int n) {
        return new int[] {
            BitOperations.PopCount((uint) n & 0x55555555U),
            BitOperations.PopCount((uint) n & 0xAAAAAAAAU)
        };
    }
}