using ApplicationCore.DTOs.Professors;
using Domain.Entities;

namespace ApplicationCore.Interfaces;

public interface IProfessorService
{
    public Task<List<Professor>> ListAdministratives();
    public Task<Professor> GetAdministrative(Guid id);
    public Task<Professor> Create(ProfessorCreateDto student);
    public Task<Professor> Update(ProfessorUpdateDto student);
    public Task Delete(Guid id);
}