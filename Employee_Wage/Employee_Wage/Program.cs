namespace Employee_Wage
{
    internal class Program
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public const int EmpRatePerHour = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Employ Wage Calculation");

            int empHrs = 0;
            int empWage = 0;


            Random random = new Random();
            int empCheck = random.Next(0, 3);


            if (empCheck == Full_Time)
            {
                empHrs = 8;
            }
            else if (empCheck == Part_Time)
            {
                empHrs = 4;
            }
            else
            {
                empHrs = 0;
            }
            empWage = empHrs * EmpRatePerHour;
            Console.WriteLine("Employ Wage is : " + empWage);
        }
    }
}