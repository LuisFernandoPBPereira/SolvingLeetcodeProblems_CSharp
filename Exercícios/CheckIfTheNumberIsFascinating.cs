public class Solution {
    public bool IsFascinating(int n) {
        int resN2, resN3;
        resN2 = n*2;
        resN3 = n*3;
        string number="", nStr="", resN2Str="", resN3Str="";

        nStr = n.ToString();
        resN2Str = resN2.ToString();
        resN3Str = resN3.ToString();
        
        number = string.Concat(nStr, resN2Str);
        number = string.Concat(number, resN3Str);

        if(number.ToString().Contains("0")) return false;
        HashSet<char> nums = new HashSet<char>();
        foreach(char caracter in number){
            nums.Add(caracter);
        }
        
        return nums.Count==number.Length;
    }
}