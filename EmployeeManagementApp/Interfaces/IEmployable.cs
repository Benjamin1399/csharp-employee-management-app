namespace EmployeeManagementApp
{
    public interface IEmployable : IPayable
    {
        string EmployeeName { get; set; }

        int EmployeeId { get; set; }

        string Department { get; set; }

        decimal HourlyRate { get; set; }

    }
}
