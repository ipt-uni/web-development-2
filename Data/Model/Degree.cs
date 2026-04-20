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
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório!")]
        [StringLength(100)]
        [Display(Name = "Curso")] // defines the name to appear on screen
        public string Name { get; set; } = "";

        /// <summary>
        /// name of the file containing the Degree logotype
        /// </summary>
        [Display(Name = "Logótipo")] // defines the name to appear on screen
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
