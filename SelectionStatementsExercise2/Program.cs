namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favorite subjest");
            String subjest = Console.ReadLine();
            switch (subjest.ToLower())
            {
                case "science":
                    Console.WriteLine("I love Sciense");
                    break;
                case "math":
                    Console.WriteLine("I hate Math");
                    break;
                case "history":
                    Console.WriteLine("History is The best");
                    break;
                case "english":
                    Console.WriteLine("English is fun");
                    break;
                case "geography":
                    Console.WriteLine("Geography is interesting");
                    break;
                default:
                    Console.WriteLine("I don't recognize that subject. ");
                    break;



            }
        }
    }
}