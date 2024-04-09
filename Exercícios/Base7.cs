public class Solution {
    public string ConvertToBase7(int num) {
        int resto, value=num;
        string number="", reverse="";
        if(num==0) return "0";

        while(num != 0){
            resto = num%7;
            num /= 7;
            number += resto.ToString();
        }
        if(value<0){
            number = number.Replace("-", "");
            reverse = "-";
        }
        for(int i=0, j=number.Length-1; j>=0; j--){
            reverse +=number[j];
        }

        return reverse;
    }
}