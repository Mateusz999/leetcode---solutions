public class Solution {
    public int[] SearchRange(int[] nums, int target) {
        int[] index = new int[2];
        index[0] = -1; // Domyślny pierwszy indeks
        index[1] = -1; // Domyślny ostatni indeks
        
        if (nums.Length == 0) {
            return index; // Jeśli tablica jest pusta, zwróć [-1, -1]
        }

        // Funkcja do znalezienia pierwszego wystąpienia
        int FindFirst() {
            int left = 0, right = nums.Length - 1, result = -1;
            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) {
                    result = mid;
                    right = mid - 1; // Kontynuuj w lewej części
                } else if (nums[mid] < target) {
                    left = mid + 1;
                } else {
                    right = mid - 1;
                }
            }
            return result;
        }

        // Funkcja do znalezienia ostatniego wystąpienia
        int FindLast() {
            int left = 0, right = nums.Length - 1, result = -1;
            while (left <= right) {
                int mid = left + (right - left) / 2;
                if (nums[mid] == target) {
                    result = mid;
                    left = mid + 1; // Kontynuuj w prawej części
                } else if (nums[mid] < target) {
                    left = mid + 1;
                } else {
                    right = mid - 1;
                }
            }
            return result;
        }

        // Znajdź pierwszy i ostatni indeks
        index[0] = FindFirst();
        if (index[0] == -1) {
            return index; // Jeśli nie znaleziono pierwszego, nie ma sensu szukać ostatniego
        }
        index[1] = FindLast();

        return index;
    }
}
