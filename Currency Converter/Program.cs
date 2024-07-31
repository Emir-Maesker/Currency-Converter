namespace Currency_Converter
{
    internal class Program
    {
        const double Rate = 0.023;

        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Enter DZD amount: ");
                    string input = Console.ReadLine();
                    double dzd;

                    if (double.TryParse(input, out dzd))
                    {
                        double tnd = ConvertToTND(dzd);
                        Console.WriteLine("Your amount in TND is: " + tnd);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a numeric value.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("An error occurred, Try again");
                }
            }
        }

        static double ConvertToTND(double dzd)
        {
            return dzd * Rate;
        }
    }
}
