using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TestArchitecture.DTO;
using TestArchitecture.Service;

namespace SampleArchitecture.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private IStudentService _serviceCat;
        private IMapper _mapper;

        public StudentController(IStudentService serviceCat, IMapper mapper)
        {
            _serviceCat = serviceCat;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<StudentListDTO>>> Get()
        {
            List<StudentListDTO> dto = _mapper.Map<List<StudentListDTO>>(await _serviceCat.GetAll(null));

            return Ok(dto);
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<StudentListDTO>> Get(long id)
        {
            List<StudentListDTO> dto = _mapper.Map<List<StudentListDTO>>(await _serviceCat.GetAll(x => x.Id == id));
            if (dto.Count > 0)
            {
                return Ok(dto[0]);
            }

            return BadRequest("No Data Exists");
        }
    }
}