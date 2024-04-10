public class Solution {
    public int[] SumZero(int n) {
        int[] result = new int[n];
        int content = n;

        if(n==1) {
            result[0] = 0;
            return result;
        }

        content /= 2;
        content *= -1;

        for(int i=0; i<n; i++){
            if(n % 2 == 0 && content == 0) content++;
            result[i] = content;
            content++;
        }

        return result;

    }
}