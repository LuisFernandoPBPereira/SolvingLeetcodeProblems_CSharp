public class Solution {
    public void MoveZeroes(int[] nums) {
        if(nums.Length != 1){
            int[] novoArray = new int[nums.Length];
            int cont=0, j=0;

            for(int i=0; i<nums.Length; i++){
                if(nums[i] != 0){
                    novoArray[j] = nums[i];
                    j++;
                }
                if(nums[i]==0) cont++;
            }

            for(int i=nums.Length-cont; i<cont; i++){
                    novoArray[i] = 0;
            }

            for(int i=0; i<nums.Length; i++){
                    nums[i] = novoArray[i];
            }
        }
    }
}