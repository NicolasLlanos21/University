﻿using System.ComponentModel.DataAnnotations;

namespace universityApiBackEnd.Models.DataModels
{
    public class Student : BaseEntity
    {
        [Required]  
        public string Name { get; set; } = string.Empty;
        [Required]
        public string FirstName { get; set; } = string.Empty;
        [Required]
        public string LastName { get; set; } = string.Empty;
        [Required]
        public DateTime Dob { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
