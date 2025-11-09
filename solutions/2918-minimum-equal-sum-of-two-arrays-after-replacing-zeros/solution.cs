public class Solution {
    public long MinSum(int[] nums1, int[] nums2) {
        long Snum1 = 0;
        long  Snum2 = 0;
        long Znum1 = 0;
        long Znum2 = 0;
        /*
        Dwie pętlę poniżej sumujemy cała tablice oraz zbieramy ilość zer
        */
        foreach(int i in nums1 ){
            if(i == 0) Znum1+=1;
            Snum1+=i;
        }

         foreach(int i in nums2 ){
            if(i == 0) Znum2+=1;
            Snum2+=i;
        }
        /*
        Do sumy tablicy dodajemy sume zer, robimy to z tego względu, że każdy elementu musi byc niezerowy
        */
        long min1 = Snum1 + Znum1;
        long min2 = Snum2 + Znum2;
        // jeśli oba nie mają zer, ale są równe to zwróci tą sume, jeśli False to -1
        if (Znum1 == 0 && Znum2 == 0) 
        return Snum1 == Snum2 ? Snum1 : -1;
        // jeśli w pierwszy suma zer wynosi zero, jednak suma tablicy plus zera są mniejsze bądź równe
        // drugiej tablicy to oznacza ze sumy mogą być równe
        else if (Znum1 == 0) 
            return (min2 <= min1) ?  min1 : -1;

        else if (Znum2 == 0) 
            return (min1 <= min2) ?  min2 : -1;

        return Math.Max(min1, min2);
    }
    
}