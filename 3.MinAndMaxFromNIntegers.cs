
class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < n; i++) a[i] = int.Parse(Console.ReadLine());

            int min=a[0], max=a[0];
            for (int i = 1; i < n; i++)
            {
                if (a[i] > max) max = a[i];
                if (a[i] < min) min = a[i];
            }

            Console.WriteLine("min = {0}, max = {1}", min, max);
        }
    }