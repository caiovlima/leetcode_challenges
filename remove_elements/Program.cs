namespace remove_elements;

// https://leetcode.com/problems/remove-element/description/?envType=study-plan-v2&envId=top-interview-150
class Program
{    
    static void Main(string[] args)
    {
        int[] nums1 = { 1, 2, 3, 0, 0, 0 };
        int valof = 0;
        List<int> nList = new List<int>();
        Console.WriteLine(RemoveElement(nums1, valof));
    }

    public static int RemoveElement(int[] nums, int val) {
        int k = 0; //ponteiro controlador

        // 1 - percorre o array
        foreach (var n in nums)
        {
            if (n != val)
            {
                // 2 - se o valor do elemento é diferente de val, então
                // o índice percorrido vai receber o valor de n 
                nums[k] = n;
                k++;
            }
        }

        return k;
    }
}
