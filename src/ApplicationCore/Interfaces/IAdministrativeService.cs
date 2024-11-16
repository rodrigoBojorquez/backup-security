using ApplicationCore.DTOs.Administratives;
using ApplicationCore.DTOs.Colaborators;
using Domain.Entities;

namespace ApplicationCore.Interfaces;

public interface IAdministrativeService
{
    public Task<List<Administrative>> ListAdministratives();
    public Task<Administrative> GetAdministrative(Guid id);
    public Task<Administrative> Create(AdministrativeCreateDto student);
    public Task<Administrative> Update(AdministrativeUpdateDto student);
    public Task Delete(Guid id);
}