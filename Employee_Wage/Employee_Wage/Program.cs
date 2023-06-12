namespace Employee_Wage
{
    internal class Program
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;
        public const int EmpRatePerHour = 20;
        public const int NumOfWorkDay = 20;
        public const int MaxHourInMonth = 100;

        public static int computeEmpWage()
        {
            Console.WriteLine("Employ Wage Calculation");

            int empHrs = 0, totalEmpHrs = 0, totalWorkDay = 0;

            while (totalEmpHrs <= MaxHourInMonth && totalWorkDay < NumOfWorkDay)
            {
                totalWorkDay++;
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
                totalEmpHrs += empHrs;
                Console.WriteLine("Day" + totalWorkDay + "Employee Hour" + empHrs);
            }
            int totalEmpWage = totalEmpHrs * EmpRatePerHour;
            Console.WriteLine("Total Employ Wage is : " + totalEmpWage);
            return totalEmpWage;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Employ Wage Calculation");
            computeEmpWage();
        }
    }
}