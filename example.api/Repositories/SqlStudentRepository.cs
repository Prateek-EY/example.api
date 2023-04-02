using example.api.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example.api.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly EmployeeDbContext _employeeDbContext;
        public SqlStudentRepository(EmployeeDbContext context)
        {
            _employeeDbContext = context;
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await _employeeDbContext.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }
    }
}
