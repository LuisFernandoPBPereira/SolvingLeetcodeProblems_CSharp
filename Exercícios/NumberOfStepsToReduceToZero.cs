public class Solution {
    public int NumberOfSteps(int num) {
        int cont=0;
        while(num!=0){
            if(num%2==0)
                num /= 2;
            else
                num -= 1;

            cont++;
        }

        return cont;
    }
}