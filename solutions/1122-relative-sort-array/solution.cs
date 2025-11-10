public class Solution {
    public int[] RelativeSortArray(int[] arr1, int[] arr2) {
        int arrLong = (arr1.Length > arr2.Length)? arr1.Length : arr2.Length;
        int[] res = new int[arrLong];
        int idx = 0;
        foreach(int el in arr2){
            foreach(int e in arr1){
                if(e == el){
                    res[idx] = el;
                    idx++;
                }
            }
        }
        Array.Sort(arr1);
        foreach(int a1 in arr1){
            if(!arr2.Contains(a1)){
                res[idx] = a1;
                idx++;
            }
        }

        return res;
    }
}