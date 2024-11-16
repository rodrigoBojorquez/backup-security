namespace ApplicationCore.DTOs.Colaborators;

public class ColaboratorUpdateDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
    public bool IsProfessor { get; set; }
}