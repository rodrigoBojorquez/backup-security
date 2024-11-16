using ApplicationCore.DTOs.Students;
using ApplicationCore.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure.Services;

public class StudentService : IStudentService
{
    private readonly ApplicationDbContext _context;
    
    public StudentService(ApplicationDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Student>> ListStudents()
    {
        return await _context.Students.ToListAsync();
    }

    public async Task<Student> GetStudent(int id)
    {
        return await _context.Students.FirstOrDefaultAsync(u => u.Id == id);
    }

    public async Task<Student> CreateStudent(StudentCreateDto student)
    {
        var entity = new Student
        {
            Name = student.Name,
            LastName = student.LastName,
            Email = student.Email
        };

        await _context.Students.AddAsync(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task<Student> UpdateStudent(StudentUpdateDto student)
    {
        var entity = await _context.Students.FirstOrDefaultAsync(u => u.Id == student.Id);
        entity.Name = student.Name;
        entity.LastName = student.LastName;
        entity.Email = student.Email;
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task DeleteStudent(int id)
    {
        var entity = await _context.Students.FirstOrDefaultAsync(u => u.Id == id);
        _context.Students.Remove(entity);
        await _context.SaveChangesAsync();
    }
}