namespace ApplicationCore.DTOs.Professors;

public class ProfessorUpdateDto
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Department { get; set; }
    public Guid ColaboratorId { get; set; }
}