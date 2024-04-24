namespace rotate_elements;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public void Rotate(int[] nums, int k)
    {
        int n = nums.Length;
        k = k % n; // reduce k to the smallest positive integer equivalent

        Reverse(nums, 0, n - 1);
        Reverse(nums, 0, k - 1);
        Reverse(nums, k, n - 1);
    }

    private void Reverse(int[] nums, int left, int right)
    {
        while (left < right)
        {
            int temp = nums[left];
            nums[left] = nums[right];
            nums[right] = temp;
            left++;
            right--;
        }
    }
}
