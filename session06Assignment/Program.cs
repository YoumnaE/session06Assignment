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

            #region Q4

            PrintBookTitle("Clean Code");

            #endregion

            #region Q5

            int pages = 400;
            AddBonusPages(pages);

            #endregion



            Console.ReadLine();
        }

        #region Q3 Method

        public static void PrintWelcomeMessage()
        {
            Console.WriteLine("Welcome to the Library!");
        }

        #endregion

        #region Q4 Method
        public static void PrintBookTitle(string title) { 
        Console.WriteLine("Book title: " + title);
        }

        #endregion

        #region Q5 Method

        public static void AddBonusPages(int pages)
        {
            int totalPages = pages + 50;
            Console.WriteLine("Number of pages: " + totalPages);
        }

        #endregion
    }

}
