using ApplicationCore.DTOs.Colaborators;
using ApplicationCore.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Services;

public class ColaboratorService : IColaboratorsService
{
    private readonly ApplicationDbContext _context;

    public ColaboratorService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Colaborator>> ListColaborators()
    {
        return await _context.Colaborators.ToListAsync();
    }

    public async Task<Colaborator> GetColaborator(Guid id)
    {
        throw new NotImplementedException();
    }

    public async Task<Colaborator> Create(ColaboratorCreateDto request)
    {
        var entity = new Colaborator
        {
            Name = request.Name,
            Age = request.Age,
            BirthDate = request.BirthDate,
            IsProfessor = request.IsProfessor
        };
        
        await _context.Colaborators.AddAsync(entity);


        if (request.IsProfessor)
        {
            var professor = new Professor
            {
                ColaboratorId = entity.Id,
            };
            await _context.Professors.AddAsync(professor);
        }
        else
        {
            var administrative = new Administrative
            {
                ColaboratorId = entity.Id,
            };
            await _context.Administratives.AddAsync(administrative);
        }
        
        await _context.SaveChangesAsync();

        return entity;
    }

    public async Task<Colaborator> Update(ColaboratorUpdateDto student)
    {
        throw new NotImplementedException();
    }

    public async Task Delete(Guid id)
    {
        throw new NotImplementedException();
    }
}