using ArrayStudy.OparationArrays;

namespace ArrayStudy
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayOrder arrayOrder = new ArrayOrder();
            int[] array = new int[9] { 9, 5, 8, 4, 3, 1, 7, 2, 6 };

            Console.WriteLine("Origin Array");
            arrayOrder.ArrayPrint(array);

            //arrayOrder.BubbleSortOrder(ref array);
            arrayOrder.SortOrder(ref array);
            Console.WriteLine("Sorted Array");
            arrayOrder.ArrayPrint(array);
        }
    }
}
