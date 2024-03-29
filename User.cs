namespace ConsoleApp2;

class User
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

    public ICollection<Account> Accounts { get; set; } = null!;
}