public class Solution {
    public int[] SingleNumber(int[] nums) {
        int cont=0, indice=0;
        int[] res = new int[2];
        for(int i=0; i<nums.Length; i++){
            for(int j=0; j<nums.Length; j++){
                if(nums[i] == nums[j])
                    cont++;
            }
            if(cont == 1) {
                res[indice] = nums[i];
                indice++;
            }
            cont=0;
        }

        return res;
    }
}   