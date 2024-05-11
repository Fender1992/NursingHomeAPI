using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NursingHomeAPI.Domains;
using NursingHomeAPI.DTO;
using NursingHomeAPI.Repositories;

namespace NursingHomeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidentActionController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IResidentRepository _residentRepository;

        public ResidentActionController(IMapper mapper, IResidentRepository residentRepository)
        {
            _mapper = mapper;
            _residentRepository = residentRepository;
        }

        [HttpPost]
        [Route("/AddUser")]
        public async Task<IActionResult> AddResident([FromBody] ResidentDto residentDto)
        {
            var newResident = _mapper.Map<Resident>(residentDto);
            newResident = await _residentRepository.AddResidentAsync(newResident);
            return CreatedAtAction(nameof(AddResident), newResident);
        }

    }
}
