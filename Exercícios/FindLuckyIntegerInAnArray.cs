public class Solution {
    public int FindLucky(int[] arr) 
    {
        int cont=0, result=0, maior=0;
        HashSet<int> hashset = new HashSet<int>();

        for(int i=0; i<arr.Length; i++)
        {
            hashset.Add(arr[i]);
        }

        foreach(var item in hashset)
        {
            cont=0;
            
            for(int j=0; j<arr.Length; j++)
            {
                if(item == arr[j])
                    cont++;
            }
            if(cont == item && cont > maior)
                maior = cont;
        }

        return maior!=0 ? maior : -1;
    }
}