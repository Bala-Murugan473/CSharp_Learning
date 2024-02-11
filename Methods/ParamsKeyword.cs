namespace CSharp_Learning.Methods
{
    internal class ParamsKeyword
    {
        public static void SumOfAllItems(params int[]? items)
        {
            if (items == null || items.Length == 0)
            {
                Console.WriteLine("No items passed");
                return;
            }
            var sum = 0;
            foreach (var item in items) { sum += item; }
            Console.WriteLine("sum of all items is : " + sum);
        }
        static void Main()
        {
            SumOfAllItems(1,2,3,4,5);   // various number of arguments
            SumOfAllItems();                // zero argument
            SumOfAllItems(null);          // null argument
            int[] items = { 1,2,3,5 };
            SumOfAllItems(items);       // array argument
        }
    }
}
