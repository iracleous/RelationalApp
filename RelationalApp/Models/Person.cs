namespace RelationalApp.Models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? Description { get; set; }
        public DateOnly RegistrationDate { get; set; }
        public decimal Balance {  get; set; }
        public bool IsAdmin { get; set; }
        public PersonCategory Category { get; set; }
    }
}
