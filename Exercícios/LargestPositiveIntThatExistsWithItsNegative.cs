public class Solution {
    public int FindMaxK(int[] nums) 
    {
        int result=0;
        for(int i=0; i<nums.Length; i++)
        {
            for(int j=0; j<nums.Length; j++)
            {
                if(i == j) continue;

                else if(Math.Abs(nums[j]) == nums[i] && nums[i] > result && nums[j]<0)
                    result = nums[i];
            }
        }
        return result == 0 ? -1 : result;
    }
}