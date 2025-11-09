/**
 * The Rand7() API is already defined in the parent class SolBase.
 * public int Rand7();
 * @return a random integer in the range 1 to 7
 */
public class Solution : SolBase {
    public int Rand10() {
        while (true)
        {
            var firstArg = Rand7();
            var secondArg = Rand7();
            int result = (firstArg - 1) * 7 + secondArg;

            if (result <= 40)
            {
                return (result % 10) + 1;
            }
        }
    }
}