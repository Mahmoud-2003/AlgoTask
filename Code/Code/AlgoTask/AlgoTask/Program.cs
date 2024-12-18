using AlgoTask;

internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = { 12, 11, 13, 5, 6, 7 };
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(" --------------------");
        Console.WriteLine("|"+"Array before sorting"+"|");
        Console.WriteLine(" --------------------");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(string.Join(", ", array));
        Console.ResetColor();
        Console.WriteLine("---------------------------------------------------------");


        HeapSort heapSort = new HeapSort();
        heapSort.Sort(array);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine(" --------------------");
        Console.WriteLine("|" + "Array after sorting" + " |");
        Console.WriteLine(" --------------------");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(string.Join(", ", array));

        Console.ResetColor();
    }
}