namespace Employee_Wage
{
    internal class Program
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public const int EmpRatePerHour = 20;
        public const int NumOfWorkDay = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Employ Wage Calculation");

            int empHrs = 0;
            int empWage = 0;
            int totalEmpWage = 0;

            for (int day = 0; day < NumOfWorkDay; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case Full_Time:
                        empHrs = 8;
                        break;
                    case Part_Time:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                empWage = empHrs * EmpRatePerHour;
                totalEmpWage += empWage;
            }
            Console.WriteLine("Total Employ Wage is : " + totalEmpWage);
        }
    }
}