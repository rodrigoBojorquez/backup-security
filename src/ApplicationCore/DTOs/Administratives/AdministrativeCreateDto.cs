namespace ApplicationCore.DTOs.Administratives;

public class AdministrativeCreateDto
{
    public string Email { get; set; }
    public string Position { get; set; }
    public string Payroll { get; set; }
    public Guid ColaboratorId { get; set; }
}