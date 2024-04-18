namespace remove_duplicates;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length == 0) return 0; // Se o array estiver vazio, não há duplicatas

        int uniqueCount = 1; // Inicialmente, temos pelo menos um número único

        // Percorre o array a partir do segundo elemento
        for (int i = 1; i < nums.Length; i++)
        {
            // Se encontrarmos um número diferente do anterior, atualizamos a próxima posição única
            if (nums[i] != nums[uniqueCount - 1])
            {
                nums[uniqueCount] = nums[i];
                uniqueCount++;
            }
        }
        return uniqueCount;

    }
}
