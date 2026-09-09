namespace EmployeeManagementApp
{
    public class ContractorModel : EmployeeModel, IPayable
    {
        public int HoursWorked { get; set; }
        public decimal CalculateMonthlyPay()
        {
            return HoursWorked * HourlyRate;
        }
    }
}
