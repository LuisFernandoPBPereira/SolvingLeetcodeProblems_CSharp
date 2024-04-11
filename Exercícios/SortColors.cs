public class Solution {
    public void SortColors(int[] nums) {
        int[] rgb = {0,1,2};

        int[] sort = new int[nums.Length];
        int cont=0;
        
        for(int i=0; i<rgb.Length; i++){
            for(int j=0; j<nums.Length; j++){
                if(nums[j] == rgb[i]){
                    sort[cont] = rgb[i];
                    cont++;
                }
            }   
        }
        for(int i=0; i<sort.Length; i++){
            nums[i] = sort[i];
        }
    }
}