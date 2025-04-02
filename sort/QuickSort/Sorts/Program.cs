using static System.Runtime.InteropServices.JavaScript.JSType;

public class Program{
    public static void Main()
    {
        int[] a = new int[10] { 2, 5, 1, 124, 1313, 1353, 1, 4, -13143, 42 };
        QuickSort(a, 0, a.Length - 1);
        foreach(int result in a)
            Console.WriteLine(result);
    }
    public static void QuickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivot = Partition(arr, left, right);
            QuickSort(arr, left, pivot - 1);
            QuickSort(arr, pivot + 1, right);
        }
    }

    private static int Partition(int[] arr, int left, int right)
    {
        int pivot = arr[right];
        int i = left - 1;
        for (int j = left; j < right; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                Swap(arr, i, j);
            }
        }
        Swap(arr, i + 1, right);
        return i + 1;
    }
    private static void Swap(int[] arr, int i, int j) => (arr[i], arr[j]) = (arr[j], arr[i]);
}