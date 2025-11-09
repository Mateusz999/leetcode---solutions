impl Solution {
    pub fn alternating_sum(nums: Vec<i32>) -> i32 {
        let mut res = 0;
        for (i, val) in nums.iter().enumerate() {
            if i % 2 == 0 {
                res += val;
            } else {
                res -= val;
            }
        }
        res
    }
}
