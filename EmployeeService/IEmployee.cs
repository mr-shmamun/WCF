namespace EmployeeService
{
    public interface IEmployee
    {
        string Address { get; set; }
        int Id { get; set; }
        string Mobile { get; set; }
        string Name { get; set; }
    }
}