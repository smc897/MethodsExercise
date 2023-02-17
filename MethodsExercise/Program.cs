namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            story();
            Console.WriteLine("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("axbx5=" + multiply(a, b, 5));
            Console.WriteLine("a/b/5=" + divide(a, b, 5));
            Console.WriteLine("a+b+5=" + add(a, b, 5));
            Console.WriteLine("a-b-5=" + subtract(a, b, 5));
        }

        //function to tell a story
        static void story() {
            Console.WriteLine("enter a name:");
            String name = Console.ReadLine();
            Console.WriteLine("enter a verb:");
            String verb = Console.ReadLine();
            Console.WriteLine("enter a toy:");
            String toy = Console.ReadLine();
            Console.WriteLine(name + "" + verb + " with " + toy + " today. ");
        }

        static int multiply(params int[] arr)
        {
            int res = 1;
            for (int i = 0; i < arr.Length; i++) res *= arr[i];
            return res;
        }

        static int divide(params int[] arr)
        {
            int res = 1;
            for (int i = 0; i < arr.Length; i++) res /= arr[i];
            return res;
        }

        static int add(params int[] arr)
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++) res += arr[i];
            return res;
        }

        static int subtract(params int[] arr)
        {
            int res = 0;
            for (int i = 0; i < arr.Length; i++) res -= arr[i];
            return res;
        }



    }
}
