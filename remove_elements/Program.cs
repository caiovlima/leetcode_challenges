namespace remove_elements;

// https://leetcode.com/problems/remove-element/description/?envType=study-plan-v2&envId=top-interview-150
class Program
{
    static void Main(string[] args)
    {
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int valof = 0;

        Console.WriteLine(RemoveElement(nums1, valof));
    }

    public int RemoveElement(int[] nums, int val)
    {
        int k = 0; // Contador para elementos diferentes de val

        // Percorre o array nums
        foreach (var num in nums.ToList())
        {
            if (num != val)
            {
                nums[k++] = num; // Move o elemento diferente de val para a posição k
            }
        }

        return k; // Retorna o número de elementos diferentes de val

    }
}
