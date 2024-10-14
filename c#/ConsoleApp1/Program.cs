class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Hello, c#");

        int[] products = new int[3];

        int[] p = new int[3];
        p[0] = 10;

        test();

        int[] arr = new int[] {1,2,3,4,5};
        foreach (int elem in arr)
        {
            Console.Write(elem + ",");
        }
    }

    static void test()
    {
        Console.WriteLine("test");
    }
}