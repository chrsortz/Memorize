namespace CRUD1.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int Age { get; set; }
        public DateTime? DateOfHire { get; set; }
        public string? Email { get; set; }
        public string? Position { get; set; }
        public double? Salary { get; set; }
    }
}
