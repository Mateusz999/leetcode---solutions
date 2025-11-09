public class Solution {
    public int[] Decode(int[] encoded, int first) {
        int[] res = new int [encoded.Length+1];

        res[0] = first;
        for(int i = 0;i<res.Length - 1; i++){
            res[i+1] = encoded[i] ^ res[i];    
        }
        
        return res;

    }

}

/*
0001
0010
0110

------
0001 = 1 
0011 xor 0001 = 0010 = 2 
0010 xor 0010 = 0000 = 0 
0001 xor 0000 = 0001 = 1 






*/