namespace session06Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            double[] prices = [25.5, 40.0, 33.75];
            Console.WriteLine(prices[1]);
            #endregion

            #region Q2

            int[,] shelfCopies = { { 3, 5 }, { 1, 1 } };
            Console.WriteLine(shelfCopies[0, 0]);

            #endregion

            #region Q3

            PrintWelcomeMessage();

            #endregion
            Console.ReadLine();
        }

        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }
    }

}
