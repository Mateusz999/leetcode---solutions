public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(nums); // sortujemy cała tablice
        for(int i =0;i<nums.Length-2;i++){ 
               if (i > 0 && nums[i] == nums[i - 1]) // jeśli na początku posortowanej tablicy beda te same to pomijamy
                continue;
            int first = nums[i]; // nasz pierszy analizowany
            int start = i+1;    // nasz lewy zakres
            int end = nums.Length-1; // nasz prawy zakres
            while(start<end){ // dopoki zakresy sie nie spotkaja
                int second = nums[start]; 
                int third = nums[end];
                if(first + second + third == 0){ // jesli warunek jest spełniony dodajemy
                  result.Add(new List<int> { first, second, third });  
                  while(start<end && nums[start] == nums[start+1]) start++; // pomijamy duplikaty w posortowanej liscie
                  while(start<end && nums[end] == nums[end-1]) end--;
                  start++;
                  end--;
                } 
                else if( first + second + third > 0 ){ end--;} // jesli wynik za duzy to odejmujemy sobie gorny zakres
                else{ start++;} // jesli wynik za maly dodajemy sobie zakres;
            }
        }
        return result;
    }
}