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
    public class TeacherController : ControllerBase
    {
        private ITeacherService _serviceCat;
        private IMapper _mapper;

        public TeacherController(ITeacherService serviceCat, IMapper mapper)
        {
            _serviceCat = serviceCat;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<List<TeacherList>>> Get()
        {
            List<TeacherList> dto = _mapper.Map<List<TeacherList>>(await _serviceCat.GetAll(null));
            return Ok(dto);
        }
    }
}