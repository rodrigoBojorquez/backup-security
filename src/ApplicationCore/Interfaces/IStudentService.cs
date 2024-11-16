using ApplicationCore.DTOs.Students;
using Domain.Entities;

namespace ApplicationCore.Interfaces;

public interface IStudentService
{
    public Task<List<Student>> ListStudents();
    public Task<Student> GetStudent(int id);
    public Task<Student> CreateStudent(StudentCreateDto student);
    public Task<Student> UpdateStudent(StudentUpdateDto student);
    public Task DeleteStudent(int id);
}