public class Solution {
    public double MyPow(double x, int n) {
        double resultado=1, temp=0;
        bool isNegative = false;

        long expoente = Math.Abs((long)n);
        
        if(x == 1) return 1;

        if(n < 0)
            isNegative = true;

        while(expoente > 0){
            // Operado "E" binário, executa uma operação bit a bit
            if((expoente & 1) == 1)
            resultado *= x;

            x *= x;

            //deslocamento de bits para a direita
            expoente >>= 1;
        }

        if(isNegative)
            temp = 1/resultado;

        return n < 0 ? temp : resultado;
    }
}