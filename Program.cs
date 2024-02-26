namespace NumberClassificationSalvador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {
                Console.WriteLine("This is a positive number.");
            }
            else if (number < 0)
            {
                Console.WriteLine("This is a negative number."); ;
            }
            else
            {
                Console.WriteLine("This is zero.");
;            }
        }
    }
}
