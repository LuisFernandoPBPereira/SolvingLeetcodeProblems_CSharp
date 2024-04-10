public class Solution {
    public int Reverse(int x) {

        int resto=0;
        string result = "";

        if(x > -10 && x < 10) return x;

        if(x < 0){
            result="-";
            x = -x;
        }
        while(x!=0){
            resto = x%10;
            x /= 10;            
            result += resto.ToString(); 
        }

        int reversedInt;
        if (int.TryParse(result, out reversedInt)) {
            return reversedInt;
        } 
        return 0;
    }
}