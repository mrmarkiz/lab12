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
                    case 3:
                        Task3.Run();
                        break;
                    case 4:
                        Task4.Run();
                        break;
                    case 5:
                        Task5.Run();
                        break;
                }
            } while (choice != 0);
        }
    }
}