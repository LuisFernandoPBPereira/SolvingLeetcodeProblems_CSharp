public class Solution {
    public string ToLowerCase(string s) {
        char[] alfabeto = {
          'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm',
          'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'
        };
        char[] result = s.ToCharArray();
        string finalResult="";

        for(int i=0; i<s.Length; i++){
            for(int j=0; j<alfabeto.Length; j++){
                if(result[i].Equals(char.ToUpper(alfabeto[j]))){
                    result[i] = alfabeto[j];
                    break;
                }
            }
            finalResult += result[i].ToString();
        }

        return finalResult;
    }
}