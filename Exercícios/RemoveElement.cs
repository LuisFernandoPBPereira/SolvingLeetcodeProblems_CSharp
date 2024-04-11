public class Solution {
    public int RemoveElement(int[] nums, int val) {
        
        int indice=0;

        foreach(var num in nums){
            if(num != val){
                nums[indice] = num;
                indice++;
            }
        }

        return indice;
    }
}