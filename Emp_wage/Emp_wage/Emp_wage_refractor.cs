using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMPLOYEEWAGEPROBLEM
{
    internal class EmployeeWage
    {
        public const float EmpWagePerHour = 20;
        public const int FullTime_WorkingHrs_PerDay = 8;
        public const int PartTime_WorkingHours_PerDay = 4;
        public const int MAX_WORKING_HRS = 100;
        public const int MAX_WORKING_DAYS = 20;
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int IS_ABSENT = 0;
        float EmpDailyWage = 0;
        public float TotalWage = 0;

        public int IsEmployeePresent()
        {
            return new Random().Next(0, 3);
        }

        public void CalculateEmpWage()
        {
            int DayNumber = 1;
            int EmpWorkingHours = 0;
            int TotalWorkingHrs = 0;
            while (DayNumber <= MAX_WORKING_DAYS && TotalWorkingHrs <= MAX_WORKING_HRS)
            {

                switch (IsEmployeePresent())
                {
                    case IS_ABSENT:
                        EmpWorkingHours = 0;
                        break;

                    case IS_PART_TIME:
                        EmpWorkingHours = PartTime_WorkingHours_PerDay;
                        break;

                    case IS_FULL_TIME:
                        EmpWorkingHours = FullTime_WorkingHrs_PerDay;
                        break;
                }
                EmpDailyWage = EmpWorkingHours * EmpWagePerHour;

                TotalWage += EmpDailyWage;
                DayNumber++;
                TotalWorkingHrs += EmpWorkingHours;
            }
            Console.WriteLine("Total working days :" + (DayNumber) + "\n Total working hours :" + TotalWorkingHrs + "");

        }

    }
}
