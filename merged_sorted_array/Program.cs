namespace merged_sorted_array;

class Program
{
    // https://leetcode.com/problems/merge-sorted-array/?envType=study-plan-v2&envId=top-interview-150
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }

    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {

        // Merge os elementos de nums2 em nums1
        for (int i = 0; i < n; i++)
        {
            nums1[m + i] = nums2[i];
        }

        // Ordena o array resultante
        Array.Sort(nums1);

        // utilizando linq
        // take passando int para pegar os primeiros elementos de num1 e num2
        var mergedArray = nums1.Take(m)
                       .Concat(nums2.Take(n))
                       .OrderBy(num => num)
                       .ToArray();

        Array.Copy(mergedArray, nums1, mergedArray.Length);

    }
}
