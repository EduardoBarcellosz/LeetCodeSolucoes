public class Solution {
    public bool IsPowerOfTwo(int n) {
        for (int k = 0; k < 31; k++) {
            if (Math.Pow(2,k) == n)
                return true;
        }
        return false;
    }
}



// uma outra abordagem encontrada para a solução é 
   usando o operador AND para comparar potencias de 2 pelos seus bits!
/*
public bool IsPowerOfTwo(int n) {
    return n > 0 && (n & (n - 1)) == 0;

1  -> 0001
2  -> 0010
4  -> 0100
8  -> 1000

o resultado and precisa de 1 e 1 para ativar o bit ( 1 ) se nao o resultado é 0 -> true se for 0 em bits

    
*/
