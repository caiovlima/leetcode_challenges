namespace remove_duplicates;

class Program
{
    static void Main(string[] args)
    {
        int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
        Console.WriteLine("Resultado: "+ remove_duplicates(nums));
    }

    public int RemoveDuplicates(int[] nums)
    {

        if (nums.Length == 0) return 0; // Se o array estiver vazio, retorna 0

        int k = 1;  // Começamos com 1 porque o primeiro elemento é sempre único
        int lastUnique = nums[0];  // Armazena o último elemento único

        // Percorre o array a partir do segundo elemento usando um loop foreach
        foreach (var num in nums[1..])
        { // Usamos a sintaxe de slicing para ignorar o primeiro elemento
            if (num != lastUnique)
            {  // Verifica se o número atual é diferente do último único
                nums[k] = num;  // Coloca o elemento único na posição k
                lastUnique = num;  // Atualiza o último único
                k++;  // Incrementa o contador de elementos únicos
            }
        }

        return k;  // Retorna o número de elementos únicos
    }
}
