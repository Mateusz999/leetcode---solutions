impl Solution {
    pub fn sum_zero(n: i32) -> Vec<i32> {
     (1..=n / 2)
            .flat_map(|i| [i, -i])
            .chain((n % 2 == 1).then_some(0))
            .collect()
    }
}