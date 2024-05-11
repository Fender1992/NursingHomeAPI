using System.ComponentModel.DataAnnotations;

namespace NursingHomeAPI.DTO
{
    public class EmergencyContactDto
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]

        public string RelationToResident { get; set; }

        public EmergencyContactDto()
        {
            if (PhoneNumber == null)
            {
                PhoneNumber = "";
            }
            if (FirstName == null)
            {
                FirstName = "";
            }
            if (LastName == null)
            {
                LastName = "";
            }
            if (Address == null)
            {
                Address = "";
            }
            if (Email == null)
            {
                Email = "";
            }
            if (RelationToResident == null)
            {
                RelationToResident = "";
            }
        }
    }
}
