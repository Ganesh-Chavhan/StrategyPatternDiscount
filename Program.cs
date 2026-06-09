namespace StrategyPatternDiscount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiscountCalculator calculator =
           new DiscountCalculator();

            Console.Write("Enter Purchase Amount: ");
            double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            Console.WriteLine("1. Regular Customer");
            Console.WriteLine("2. Student Customer");
            Console.WriteLine("3. Premium Customer");

            Console.Write("Choose Customer Type: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    calculator.SetStrategy(
                        new RegularDiscount());
                    break;

                case 2:
                    calculator.SetStrategy(
                        new StudentDiscount());
                    break;

                case 3:
                    calculator.SetStrategy(
                        new PremiumDiscount());
                    break;

                default:
                    Console.WriteLine("Invalid Choice");
                    return;
            }

            double finalAmount =
                calculator.GetFinalAmount(amount);

            Console.WriteLine();
            Console.WriteLine($"Final Amount: Rs. {finalAmount}");
        }
    }
}
