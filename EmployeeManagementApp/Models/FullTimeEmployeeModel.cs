namespace EmployeeManagementApp
{
    public class FullTimeEmployeeModel : EmployeeModel, IPayable
    {
        public decimal CalculateMonthlyPay()
        {
            int monthlyHours = 160;
            return monthlyHours * HourlyRate;
        }
    }
}
