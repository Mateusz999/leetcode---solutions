public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        int closest = 1000000; // daje wysoki closest zeby byl spoza przedzilu
        int sum = 0;
        Array.Sort(nums); // wiadomo sortowanko
        for(int i = 0;i<nums.Length-2;i++){
            int first = nums[i];
            int left = i+1;
            int right = nums.Length-1;
            while(left < right){
                if(Math.Abs(( first + nums[left] + nums[right]) - target ) < closest ){ // sprawdzam czy mniejszy niz closest
                    sum = first + nums[left] + nums[right]; // jesli mniejszy to sume daje a closes w bezwzglednej zmieniam
                    closest = Math.Abs(( first + nums[left] + nums[right]) - target );
                    if(( first + nums[left] + nums[right]) < target)left++; // jesli mniejszy od targetu to dodajemy
                    else right--;// w innym wypadku odejmujemy

                } else{
                    if(( first + nums[left] + nums[right]) < target)left++;
                    else right--;
            // tyczy sie to rowniez jesli nie jest najblizszy
                }
            }
        }
        return sum;
    }
}