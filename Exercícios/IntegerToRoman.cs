public class Solution {
    public string IntToRoman(int num) {
        string[] roman = 
            {"I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M"};
        string result="";

        while(num != 0){
            if(num >= 1000){
            result += roman[12];
            num -= 1000;
            }
            else if(num >= 900){
                result += roman[11];
                num -= 900;
            }
            else if(num >= 500){
                result += roman[10];
                num -= 500;
            }
            else if(num >= 400){
                result += roman[9];
                num -= 400;
            }
            else if(num >= 100){
                result += roman[8];
                num -= 100;
            }
            else if(num >= 90){
                result += roman[7];
                num -= 90;
            }
            else if(num >= 50){
                result += roman[6];
                num -= 50;
            }
            else if(num >= 40){
                result += roman[5];
                num -= 40;
            }
            else if(num >= 10){
                result += roman[4];
                num -= 10;
            }
            else if(num >= 9){
                result += roman[3];
                num -= 9;
            }
            else if(num >= 5){
                result += roman[2];
                num -= 5;
            }
            else if(num >= 4){
                result += roman[1];
                num -= 4;
            }
            else if(num >= 1){
                result += roman[0];
                num -= 1;
            }
        }

        return result;
    }
}