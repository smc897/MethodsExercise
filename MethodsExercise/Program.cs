namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            story();
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
    }
}
