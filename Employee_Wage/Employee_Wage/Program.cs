namespace Employee_Wage
{
    internal class Program
    {
        public const int Full_Time = 1;
        static void Main(string[] args)
        {
            Console.WriteLine("Employ Wage Calculation");
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == Full_Time)
            {
                Console.WriteLine("Employee is present");
            }
            else
            {
                Console.WriteLine("Employee is absent");
            }
        }
    }
}