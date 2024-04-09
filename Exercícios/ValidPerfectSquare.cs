public class Solution {
    public bool IsPerfectSquare(int num) {
        if(num == 1) return true;
        
        for(long i=0; i<num; i++){
            if(i*i==num)
                return true;
        }

        return false;
    }
}