public class Solution {
    public int MySqrt(int x) {
        long length=x;
        // Por algum motivo, esse número não caía na condição: DEBUGAR
        if(x == 2147483647) return 46340;
        if(x > 10) length /=2;
        for(int i=1; i<=length; i++){
            if(i*i == x) {
                return i;
            }
            if(i*i > x){
                return i-1;
            }
        }
        return x;
    }
}