namespace SelectionSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter total number.");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[number];
            Console.WriteLine("Enter numbers.");
            for (int i = 0; i < number; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Before sorting.");
            for (int i = 0; i < number; i++)
            {
                Console.Write(arr[i] + " ");
            }


            for(int i = 0; i < number - 1; i++)
            {
                int s = i;

                for(int j = i + 1; j < number; j++)
                {
                    if (arr[j] < arr[s])
                    {
                        s = j;
                    }
                }

                int temp = arr[s];
                arr[s] = arr[i];
                arr[i] = temp;

            }

            Console.Write("After sorting.");
            for (int i = 0; i < number; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}
