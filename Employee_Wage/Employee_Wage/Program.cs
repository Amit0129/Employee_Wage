namespace Employee_Wage
{
    internal class Program
    {
        public const int Full_Time = 1;
        public const int Part_Time = 2;

        public static int computeEmpWage(string company, int empRatePerHour, int numOfWorkDay, int maxHourInMonth)
        {
            

            int empHrs = 0, totalEmpHrs = 0, totalWorkDay = 0;

            while (totalEmpHrs <= maxHourInMonth && totalWorkDay < numOfWorkDay)
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
            int totalEmpWage = totalEmpHrs * empRatePerHour;
            Console.WriteLine("Total Employ Wage for company " + company + " is " + totalEmpWage);
            return totalEmpWage;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Employ Wage Calculation");
            computeEmpWage("Tata", 100, 15, 100);
            computeEmpWage("Tesla",50,20,50);
        }
    }
}