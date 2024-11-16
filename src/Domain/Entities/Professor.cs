namespace Domain.Entities;

public class Professor
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Email { get; set; } = string.Empty;
    public string Department { get; set; } = string.Empty;
    
    public Guid ColaboratorId { get; set; }
    public Colaborator Colaborator { get; set; } = null!;
    
}