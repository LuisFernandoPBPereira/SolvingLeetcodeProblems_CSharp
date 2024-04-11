public class Solution {
    public int SingleNumber(int[] nums) {
        int cont=0, res=0;

        for(int i=0; i<nums.Length; i++){
            for(int j=0; j<nums.Length; j++){
                if(nums[i] == nums[j]){
                    cont++;
                    res = nums[i];
                }
            }
            if(cont == 1) break;
            cont=0;
        }

        return res;
    }
}