using AutoMapper;
using example.api.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace example.api.Controllers
{
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentRepository StudentRepository;
        private readonly IMapper mapper;

        public StudentController(IStudentRepository studentRepository,IMapper mapper)
        {
            StudentRepository = studentRepository;
            this.mapper = mapper;
        }

        
        [HttpGet]
        [Route("[controller]")]
        public async Task<IActionResult> GetAllStudents()
        {
            var studentModel = await StudentRepository.GetStudentsAsync();            
            return Ok(mapper.Map<List<DomainModels.Student>>(studentModel));
        }
    }
}
