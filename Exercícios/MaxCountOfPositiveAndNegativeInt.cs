public class Solution {
    public int MaximumCount(int[] nums) 
    {
        int contNegativo=0, contPositivo=0;

        for(int i=0; i<nums.Length; i++)
        {
            if(nums[i] < 0) contNegativo++;
            if(nums[i] > 0) contPositivo++;
        }

        return contPositivo > contNegativo ? contPositivo : contNegativo;
    }
}