public class Solution {
    public string IntToRoman(int num) {
        string result = "";
        if(num == 1) return "I";
        
        int units = num%10;
        num-=units;
        num/=10;
        int dec  =  num%10;
        num-=dec;
        num/=10;

        int hundred =  num%10;
        num-=hundred;
        num/=10;

        int thousand = num%10; 
        num-=thousand;
        num/=10;   
        if(units <=3){
            for(int i =1;i<=units;i++){
                result+="I";
            }
        }else if(units == 4) result+="VI";
        else if(units == 5) result +="V";
        else if(units >5 && units <9){
             for(int j = 1;j<=units-5;j++){
                result+="I";
            }
            result +="V";
           
        }else if(units == 9){
            result+="XI";
        }
           if(dec <=3){
            for(int i =1;i<=dec;i++){
                result+="X";
            }
        }else if(dec == 4) result+="LX";
        else if(dec == 5) result +="L";
        else if(dec >5 && dec <9){
             for(int j = 1;j<=dec-5;j++){
                result+="X";
            }
            result +="L";
           
        }else{
            result+="CX";
        }    

               if(hundred <=3){
            for(int i =1;i<=hundred;i++){
                result+="C";
            }
        }else if(hundred == 4) result+="DC";
        else if(hundred == 5) result +="D";
        else if(hundred >5 && hundred <9){
              for(int j = 1;j<=hundred-5;j++){
                result+="C";
            }
            result +="D";
          
        }else{
            result+="MC";
        }  

        for(int k=1;k<=thousand;k++){
            result+="M";
        }  
        char[] resultArray = result.ToCharArray();
        Array.Reverse(resultArray);
        return new string(resultArray);
    }
}