namespace Searching;

public static class Binary
{
    public static int FindMinimumIndexInRotatedSorted(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        if (nums.Length == 0) return -1;

        int start = 0, end = nums.Length - 1;

        while (start < end)
        {
            int mid = start + (end - start) / 2;

            if (nums[mid] > nums[end]) start = mid + 1;
            else end = mid;
        }

        return start;
    }

    public static int FindPeakIndex(int[] nums)
    {
        ArgumentNullException.ThrowIfNull(nums);
        if (nums.Length == 0) return -1;

        int start = 0, end = nums.Length - 1;
        while (start < end)
        {
            int mid = start + (end - start) / 2;

            if (nums[mid] < nums[mid + 1]) start = mid + 1;
            else end = mid;
        }

        return start;
    }

    public static (int Row, int Column) SearchIn2DMatrix(int[][] matrix, int target)
    {
        ArgumentNullException.ThrowIfNull(matrix);
        for (int row = 0; row < matrix.Length; row++)
        {
            int[] nums = matrix[row];
            if (nums.Length == 0 || target < nums[0] || target > nums[^1]) continue;

            int start = 0, end = nums.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (nums[mid] == target) return (row, mid);
                if (nums[mid] < target) start = mid + 1;
                else end = mid - 1;
            }
        }
        return (-1, -1);
    }

    public static (int First, int Last) FindFirstAndLastOccurrence(int[] nums, int target)
    {
        ArgumentNullException.ThrowIfNull(nums);
        return (FindBoundary(nums, target, false), FindBoundary(nums, target, true));
    }

    private static int FindBoundary(int[] nums, int target, bool findLast)
    {
        int start = 0, end = nums.Length - 1, result = -1;
        while (start <= end)
        {
            int mid = start + (end - start) / 2;
            if (nums[mid] == target)
            {
                result = mid;
                if (findLast) start = mid + 1;
                else end = mid - 1;
            }
            else if (nums[mid] > target) end = mid - 1;
            else start = mid + 1;
        }

        return result;
    }
}