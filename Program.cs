namespace COMP003A.FinalProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Console.WriteLine("test");
            bool running = true;

            Console.WriteLine("Welcome to my Friendship Application!");

            do
            {
                Console.WriteLine("Do you want to be my friend?");
                string response = Console.ReadLine();


                if (!response.ToLower().StartsWith("y"))
                {

                    running = false; 
                }

            } while (running);
        }
    }
}
