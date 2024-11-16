namespace ApplicationCore.DTOs.Professors;

public class ProfessorCreateDto
{
    public string Email { get; set; }
    public string Department { get; set; }
    public Guid ColaboratorId { get; set; }
}