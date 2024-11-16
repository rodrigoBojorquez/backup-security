namespace Domain.Entities;

public class Administrative
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Email { get; set; } = string.Empty;
    public string Position { get; set; } = string.Empty;
    public string Payroll { get; set; } = string.Empty;
    
    public Guid ColaboratorId { get; set; }
    public Colaborator Colaborator { get; set; } = null!;
}