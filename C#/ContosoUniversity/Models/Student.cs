using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    public class Student : Person
    {
        // Email Address
        [Display(Name = "Email Address")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string EmailAddress { get; set; }

        // Student GPA
        [Display(Name = "Student GPA")]
        [Range(typeof(double), "0.7", "4.0")]
        public double? StudentGPA { get; set; }

        // Credits earned
        [Display(Name = "Credits Earned")]
        public double? CreditsEarned { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Enrollment Date")]
        public DateTime EnrollmentDate { get; set; }

        // Credits earned
        [Display(Name = "Address")]
        public string Address { get; set; }

        public virtual ICollection<Enrollment> Enrollments { get; set; }
    }
}