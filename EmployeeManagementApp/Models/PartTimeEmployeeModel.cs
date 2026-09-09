namespace EmployeeManagementApp
{
    public class PartTimeEmployeeModel : EmployeeModel, IPayable
    {
        public decimal CalculateMonthlyPay()
        {
            int monthlyHours = 80;
            return monthlyHours * HourlyRate;
        }
    }
}
