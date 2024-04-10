public class Solution {
    public IList<int> AddToArrayForm(int[] num, int k) {
        string number="";
        BigInteger result=0;
        int resto=0;
        List<int> list = new List<int>();

        for(int i=0; i<num.Length; i++){
            number += num[i].ToString();
        }

        result = k + BigInteger.Parse(number);

        while(result != 0){
            resto = (int)(result%10);
            result /=10;
            list.Add(resto);
        }
        list.Reverse();

        return list;
    }
}