namespace lab12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int choice;
            do
            {
                Console.Write("Enter task to run: ");
                int.TryParse(Console.ReadLine(), out choice);
                switch (choice)
                {
                    case 1:
                        Tasks1_2.Run1();
                        break;
                    case 2:
                        Tasks1_2.Run2();
                        break;
                }
            } while (choice != 0);
        }
    }
}