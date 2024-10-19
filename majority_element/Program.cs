namespace majority_element
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definindo o array de entrada
            int[] nums = { 2, 2, 1, 1, 1, 2, 2 };

            // Chamando o método MajorityElement e imprimindo o resultado
            Console.WriteLine(MajorityElement(nums));
        }

        public static int MajorityElement(int[] nums)
        {
            // Dicionário para armazenar os números e suas contagens
            Dictionary<int, int> majorCandidates = new Dictionary<int, int>();

            // Variáveis para armazenar o número candidato (elemento majoritário) e sua contagem
            int candidate = 0;
            int count = 0;

            // Primeiro laço: conta as ocorrências de cada número em nums
            foreach (int n in nums)
            {
                // Se o número já está no dicionário, incrementa sua contagem
                if (majorCandidates.ContainsKey(n))
                {
                    majorCandidates[n]++;
                }
                // Caso contrário, adiciona o número ao dicionário com contagem inicial de 1
                else
                {
                    majorCandidates[n] = 1;
                }
            }

            // Segundo laço: percorre o dicionário para encontrar o número com a maior contagem
            foreach (var item in majorCandidates)
            {
                // Se o número atual tem uma contagem maior que a atual, atualiza o candidato e a contagem
                if (item.Value > count)
                {
                    count = item.Value;   // Atualiza a contagem com o maior valor encontrado até o momento
                    candidate = item.Key; // Atualiza o candidato para o número atual
                }
            }

            // Retorna o número que apareceu mais vezes (elemento majoritário)
            return candidate;
        }
    }
}
