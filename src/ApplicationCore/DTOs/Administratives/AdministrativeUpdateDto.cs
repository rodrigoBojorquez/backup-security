namespace ApplicationCore.DTOs.Administratives;

public class AdministrativeUpdateDto
{
    public Guid Id { get; set; }
    public string Email { get; set; }
    public string Position { get; set; }
    public string Payroll { get; set; }
    public Guid ColaboratorId { get; set; }
}