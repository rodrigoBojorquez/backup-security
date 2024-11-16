using ApplicationCore.DTOs.Colaborators;
using Domain.Entities;

namespace ApplicationCore.Interfaces;

public interface IColaboratorsService
{
    public Task<List<Colaborator>> ListColaborators();
    public Task<Colaborator> GetColaborator(Guid id);
    public Task<Colaborator> Create(ColaboratorCreateDto student);
    public Task<Colaborator> Update(ColaboratorUpdateDto student);
    public Task Delete(Guid id);
}