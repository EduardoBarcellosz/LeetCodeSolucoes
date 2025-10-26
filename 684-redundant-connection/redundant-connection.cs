public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        
        //esse exercicio é muito util para aprender sobre o Union-Find
        //usando algoiritmos de uniao em subconjuntos de caminhos, usando o mesmo pai
        //de cada nodo como referencia para percorrer e validar se o caminho gera caminhos
        //ciclicos

        int n = edges.Length;
        
        //define o conjunto de pais
        int[] parent = new int[n + 1];
        for (int i = 1; i <= n; i++){ // cada nó é seu proprio pai no inicio
            parent[i] = i;
        }
            
        for (int i = 0; i < edges.Length; i++){
            bool found = Union(parent, edges[i][0], edges[i][1]);
            if (found == false)
                return edges[i];
        }

        int Find(int[] parent, int x)
        {
            if (parent[x] != x)
                //"sobe" recursivamente ate achar o pai raiz
                parent[x] = Find(parent, parent[x]);
            return parent[x];
        }

        bool Union(int[] parent, int a, int b)
        {
            int parentA = Find(parent, a);
            int parentB = Find(parent, b);

            // Se têm o mesmo pai → ciclo encontrado
            if (parentA == parentB)
                return false;

            // Caso contrário, conecta os conjuntos
            parent[parentA] = parentB;

            return true;
        }

        return null;
    }
}