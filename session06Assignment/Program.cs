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
            Console.WriteLine("Number of pages: " + pages);
            // prints original value bec function only recieves value not the address

            #endregion

            #region Q6

            double[] prices1 = { 25.5, 40.0 };
            ApplyDiscount(prices1);
            Console.WriteLine(prices1[0]);
            // prints new value since reference type sends address to function

            #endregion

            #region Q7

            AddBonusPagesByRef(ref pages);
            Console.WriteLine(pages);
            // prints new value since we sent reference not actual value

            #endregion

            #region Q8

            ReplaceArray(ref prices1);
            Console.WriteLine(prices1.Length);

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
            pages = pages + 50;
        }

        #endregion

        #region Q6 Method

        public static void ApplyDiscount(double[] prices)
        {
            prices[0] = prices[0] - 5.0;
        }

        #endregion

        #region Q7 Method

        public static void AddBonusPagesByRef(ref int pages)
        {
            pages = pages + 50;
        }

        #endregion

        #region Q8

        public static void ReplaceArray(ref double[] prices)
        {
            prices = [ 10.0, 12.5, 15.0 ];

        }

        #endregion
    }

}
