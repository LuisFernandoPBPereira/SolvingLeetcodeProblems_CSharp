public class Solution {
    public int SumOfMultiples(int n) {
        List<int> list = new List<int>();
        for(int i=0; i<=n; i++){
            if(i%3==0 || i%5==0 || i%7==0)
                list.Add(i);
        }
        return list.Sum();
    }
}