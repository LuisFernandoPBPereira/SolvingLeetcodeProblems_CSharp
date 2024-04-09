public class Solution {
    public int[] GetNoZeroIntegers(int n) {
        int[] result = new int[2];

        for(int i=0; i<n; i++){
            for(int j=0; j<n; j++){
                if(!(i.ToString().Contains("0")) && !(j.ToString().Contains("0")) && i+j==n){
                    result[0] = i;
                    result[1] = j;
                    return result;
                }
            }
        }
        return result;
    }
}