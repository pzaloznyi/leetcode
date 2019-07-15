using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(2.0 == new Solution().FindMedianSortedArrays(new[] {1, 3}, new[] {2}));
        Console.WriteLine(2.5 == new Solution().FindMedianSortedArrays(new[] {1, 2}, new[] {3, 4}));
        Console.WriteLine(10 == new Solution().FindMedianSortedArrays(new[] {1, 2, 5, 6, 10, 34, 54}, new[] {3, 4, 6, 100, 101, 145, 543, 655}));
    }
}

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        return Median(MergeArray(nums1, nums2));
    }

    private int[] MergeArray(int[] leftArr, int[] rightArr)
    {
        int[] arr = new int[leftArr.Length + rightArr.Length];

        int leftIndex = 0,
            rightIndex = 0,
            index = 0;

        while (leftIndex < leftArr.Length && rightIndex < rightArr.Length)
        {
            if (leftArr[leftIndex] < rightArr[rightIndex])
            {
                arr[index++] = leftArr[leftIndex++];
            }
            else
            {
                arr[index++] = rightArr[rightIndex++];
            }
        }

        while (leftIndex < leftArr.Length)
        {
            arr[index++] = leftArr[leftIndex++];
        }

        while (rightIndex < rightArr.Length)
        {
            arr[index++] = rightArr[rightIndex++];
        }

        return arr;
    }

    private double Median(int[] nums)
    {
        int n = nums.Length;
        if (n % 2 == 0)
        {
            return (nums[n / 2 - 1] + nums[n / 2]) / 2D;
        }
        else
        {
            return nums[n / 2];
        }
    }
}