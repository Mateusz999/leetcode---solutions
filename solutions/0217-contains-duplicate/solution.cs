public class Solution {
    public bool ContainsDuplicate(int[] nums) {
         return new HashSet<int>(nums).Count < nums.Length;
         //jesli długosc hashSet jest ktorsza od tablicy znaczy ze jest conajmnie powtorzyony raz

    }
}