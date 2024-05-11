using NursingHomeAPI.Domains;
using System.ComponentModel.DataAnnotations;

namespace NursingHomeAPI.DTO
{
    public class ResidentDto
    {
        [Required]
        public string LastName { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string MedicalConditions { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        public int CalculateAge()
        {
            DateTime today = DateTime.Today;
            int age = today.Year - BirthDate.Year;

            if (BirthDate > today.AddYears(-age))
                age--;

            return age;
        }
        [Required]
        public EmergencyContact EmergencyContact { get; set; }

        public ResidentDto()
        {
            if (LastName == null)
            {
                LastName = "";
            }
            if (FirstName == null)
            {
                FirstName = "";
            }
            if (MedicalConditions == null)
            {
                MedicalConditions = "";
            }
            if (EmergencyContact == null)
            {
                EmergencyContact = new EmergencyContact();
            }
            if (Gender == null)
            {
                Gender = "";
            }
        }
    }
}
