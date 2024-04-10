public class Solution {
    public int SubtractProductAndSum(int n) 
    {
        int product=1, sum=0, res=0;
        while(n != 0)
        {
            res = n%10;
            n /= 10;
            product *= res;
            sum += res;
        }

        return product - sum;
    }
}