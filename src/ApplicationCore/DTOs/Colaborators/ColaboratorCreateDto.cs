namespace ApplicationCore.DTOs.Colaborators;

public class ColaboratorCreateDto
{
    public string Name { get; set; }
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
    public bool IsProfessor { get; set; } = false;
}