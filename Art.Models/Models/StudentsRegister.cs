using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace ArtAndTechnicalEducationInstitute.Models
{
    public class StudentsRegister
    {
        public int Id { get; set; }
        [Required]
        public int StudentCode { get; set; }
        [Required]
        [DisplayName("Student Name")]
        public string Name { get; set; }
        [Required]
        public string Family { get; set; }
        [Required]
        [DisplayName("Father Name")]
        public string FathersName { get; set; }
        public string Gender { get; set; }
        [Required]
        [StringLength(10)]
        [DisplayName("National ID")]
        public string NationalCard { get; set; }
        [Required]
        public string IdCard { get; set; }
        [Required]
        [DisplayName("Birth Place")]
        public string BirthPlace { get; set; }
        [Required]
        [DisplayName("Birth Date")]
        public DateOnly DateBirth { get; set; }
        [StringLength(2)]
        [MinLength(2)]
        public string Age { get; set; }
        [Required]
        public string Education { get; set; }
        [Required]
        [DisplayName("Cources")]
        public string RegisterCource { get; set; }
        [Required]
        [DisplayName("Phone Number")]
        public string PhoneNumber { get; set; }
        [Required]
        [DisplayName("Cell Phone")]
        public string CellPhone { get; set; }
        [Required]
        public string Address { get; set; }
        public float Fee { get; set; }
        [Required]
        public string Img { get; set; }
    }
}
