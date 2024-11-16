using ApplicationCore.DTOs.Professors;
using ApplicationCore.Interfaces;
using Domain.Entities;

namespace Infraestructure.Services;

public class ProfessorService : IProfessorService
{
    public Task<List<Professor>> ListAdministratives()
    {
        throw new NotImplementedException();
    }

    public Task<Professor> GetAdministrative(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Professor> Create(ProfessorCreateDto student)
    {
        throw new NotImplementedException();
    }

    public Task<Professor> Update(ProfessorUpdateDto student)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}