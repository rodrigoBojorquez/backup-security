using ApplicationCore.DTOs.Administratives;
using ApplicationCore.Interfaces;
using Domain.Entities;

namespace Infraestructure.Services;

public class AdminsitrativeService : IAdministrativeService
{
    public Task<List<Administrative>> ListAdministratives()
    {
        throw new NotImplementedException();
    }

    public Task<Administrative> GetAdministrative(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<Administrative> Create(AdministrativeCreateDto student)
    {
        throw new NotImplementedException();
    }

    public Task<Administrative> Update(AdministrativeUpdateDto student)
    {
        throw new NotImplementedException();
    }

    public Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}