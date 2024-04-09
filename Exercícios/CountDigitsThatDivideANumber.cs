public class Solution {
    public int CountDigits(int num) {
        int numCompare = num, digit, cont=0;
        
        while(numCompare != 0){
            digit = numCompare % 10;
            numCompare /= 10;
            if(num%digit==0){
                cont++;
            }
        }

        return cont;
    }
}