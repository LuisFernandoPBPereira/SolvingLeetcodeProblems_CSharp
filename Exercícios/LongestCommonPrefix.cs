public class Solution {
    public string LongestCommonPrefix(string[] strs) {

        string prefixo = strs[0];

        for(int i=0; i<strs.Length; i++){
            while(strs[i].IndexOf(prefixo) != 0){
                prefixo = prefixo.Substring(0, prefixo.Length -1);
            }
        }

        return prefixo;
    }
}