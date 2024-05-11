using AutoMapper;
using NursingHomeAPI.Domains;
using NursingHomeAPI.DTO;

namespace NursingHomeAPI.Mapper
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<EmergencyContact, EmergencyContactDto>().ReverseMap();
            CreateMap<Resident, ResidentDto>().ReverseMap();
        }
    }
}
