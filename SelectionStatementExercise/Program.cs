namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(1, 1000);
           

            Console.WriteLine("Pick a number from 1 to 1000");
            var userInput = int.Parse(Console.ReadLine());

            if(userInput < favNumber)
            {
                Console.WriteLine($"{favNumber} is too low");
            }
            else if (userInput > favNumber)
            {
                Console.WriteLine($"{userInput} is too high");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        }
    }
}
