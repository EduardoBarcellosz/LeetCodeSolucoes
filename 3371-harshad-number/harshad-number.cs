public class Solution {
    public int SumOfTheDigitsOfHarshadNumber(int x) {

        string numeros = x.ToString();
        int soma = 0;

        foreach(char numero in numeros)
            soma += (int)char.GetNumericValue(numero);

        return x % soma == 0 ? soma : -1;
    }
}