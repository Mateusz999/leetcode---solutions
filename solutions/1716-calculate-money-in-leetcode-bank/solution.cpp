class Solution {
public:
    int totalMoney(int n) {
    int32_t sum = 0;
    int32_t idx = 1;
    for(int16_t i = 1 ;i<=n;i++)
    {   
        sum+=idx+i/7;
        if(i%7 == 0) idx-=7;
        idx++;
    }
    return sum-(n/7);
    }
};