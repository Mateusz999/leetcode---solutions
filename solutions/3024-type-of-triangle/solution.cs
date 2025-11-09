public class Solution {
    public string TriangleType(int[] nums) {
        if(nums[0] + nums[1] > nums[2] &&
           nums[1] + nums[2] > nums[0] &&
           nums[2] + nums[0] > nums[1] 
        ){

            if(nums[0] == nums[1] && 
               nums[1] == nums[2] && 
               nums[0] == nums[2]) return "equilateral";
            else{
                if(nums[0] != nums[1] &&
                   nums[1] != nums[2] &&
                   nums[2] != nums[0]) return "scalene";
                else return "isosceles";
            }
        }else return "none";

    //   return nums.Sum() > nums.Max()*2 ? nums.GroupBy( x => x).Count() switch {
    //     3 => "scalene",
    //     2 => "isosceles",
    //     _ => "equilateral"
    //   } : "none";
}
}