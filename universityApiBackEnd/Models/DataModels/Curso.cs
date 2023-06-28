using System.ComponentModel.DataAnnotations;
using System.Configuration;

namespace universityApiBackEnd.Models.DataModels
{
    public class Curso: BaseEntity
    {
      
        [Required, StringLength(50)]
        public string Name { get; set; } = string.Empty;
        [Required, StringLength(280)]
        public string Description { get; set; } = string.Empty;
        [Required]
        public string LongDescription { get; set; } = string.Empty;
        [Required]
        public string TargetAudience { get; set; } = string.Empty;

        [Required]
        public string Objectives { get; set; } = string.Empty;
        [Required]
        public RequirementsEnum Requirements { get; set; }

    }
}
