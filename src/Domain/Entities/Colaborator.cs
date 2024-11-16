namespace Domain.Entities;

public class Colaborator
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string Name { get; set; } = string.Empty;
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
    public bool IsProfessor { get; set; } = false;
    
    public DateTime CreateDate { get; set; } = DateTime.UtcNow;
    
}