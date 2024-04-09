public class Solution {
    public int SearchInsert(int[] nums, int target) {
        int shouldBeIn=0;
        for(int i=0; i<nums.Length; i++){
            if(nums[i] == target){
                return i;
            }
            if(nums[i] > target){
                shouldBeIn = i;
                break;
            }
            else{
                shouldBeIn = i+1;
            }
        }
        return shouldBeIn;
    }
}