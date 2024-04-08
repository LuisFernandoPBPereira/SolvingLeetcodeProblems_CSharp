public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> resultado = new HashSet<int>();
        for(int i=0; i<nums1.Length; i++){
            for(int j=0; j<nums2.Length; j++){
                if(nums1[i] == nums2[j]){
                    resultado.Add(nums2[j]);
                }
            }
        }
        int[] array = new int[resultado.Count()];
        array = resultado.ToArray();

        return array;
    }
}