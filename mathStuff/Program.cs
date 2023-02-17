namespace mathStuff {

    public class Program {

        static void main(string[] args) {
            Console.WriteLine("Enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a second number: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("axb=" + multiply(a, b));
            Console.WriteLine("a/b=" + divide(a, b));
            Console.WriteLine("a+b=" + add(a, b));
            Console.WriteLine("a-b=" + subtract(a, b));
        }

        static int multiply(int a, int b) {
            return a * b;
        }

        static int divide(int a, int b)
        {
            return a / b;
        }

        static int add(int a, int b)
        {
            return a + b;
        }

        static int subtract(int a, int b)
        {
            return a * b;
        }
    }

}