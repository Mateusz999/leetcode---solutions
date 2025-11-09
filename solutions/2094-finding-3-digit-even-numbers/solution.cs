public class Solution {
    public int[] FindEvenNumbers(int[] digits) {
        int[] counter = new int[10];

        foreach(int d in digits) counter[d]++; // zliczamy wystąpienia danych cyfr;
        List<int> result = new List<int>();

        for(int i = 100;i<=999;i+=2){
            int h = i/100;
            int t = (i%100)/10;
            int o = i%10;
            counter[h]--; counter[t]--;counter[o]--;
            if(counter[h] >=0 && counter[t] >= 0 && counter[o] >= 0)
                result.Add(i);
                 counter[h]++; counter[t]++; counter[o]++;
            
        }
      return result.ToArray();

    }
}