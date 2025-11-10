class Solution {
public:
    int countOperations(int num1, int num2,int counter=0) {
        long repetition = 0;
        while(num1 > 0 && num2 > 0){
            if(num1 > num2) num1 -=num2;
            else num2-=num1;
            repetition++;
        }

        return repetition;


        // ------- runtime 100% memory 6,11%;
        //if(num1==0 || num2==0) return counter;
        //auto [ first, second ] = div(num1,num2);
        //return countOperations(num2,second, counter+first);
    }
};