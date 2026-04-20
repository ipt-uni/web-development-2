using System.ComponentModel.DataAnnotations;

namespace lab2.Data.Model
{
    /// <summary>
    /// Curso
    /// </summary>
    public class Degree
    {
        [Key] // PK
        public int Id { get; set; }

        /// <summary>
        /// name of the Course
        /// </summary>
        [Required(ErrorMessage = "The {0} is required!")]
        [StringLength(100)]
        [Display(Name = "Course")] // defines the name to appear on screen
        public string Name { get; set; } = "";

        /// <summary>
        /// name of the file containing the Degree logotype
        /// </summary>
        [Display(Name = "Logo")] // defines the name to appear on screen
        [StringLength(50)]
        public string? Logotype { get; set; } // the '?' will make the attribute optional

        /* ****************************************
                * Building the Relationships
                * *************************************** */

        // relationship 1-N

        /// <summary>
        /// List of subjects of the course
        /// </summary>
        public ICollection<Course> CoursesList { get; set; } = [];

        /// <summary>
        /// list of students enrolled in the course
        /// </summary>
        public ICollection<Student> StudentsList { get; set; } = [];
    }
}
