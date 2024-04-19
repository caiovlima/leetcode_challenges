namespace max_twice_numbers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public int RemoveDuplicates(int[] nums)
    {
        if (nums.Length <= 2)
            return nums.Length;

        int index = 2; // Inicializa o índice para onde inserir os elementos sem duplicatas

        for (int i = 2; i < nums.Length; i++)
        {
            // Se o elemento atual for diferente dos dois anteriores, podemos mantê-lo
            if (nums[i] != nums[index - 1] || nums[i] != nums[index - 2])
            {
                nums[index] = nums[i];
                index++;
            }
        }

        return index; // Retorna o novo tamanho do array sem duplicatas
    }
}
