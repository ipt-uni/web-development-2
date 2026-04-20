using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace lab2.Data.Model
{
    /// <summary>
    /// Subject that belongs to a course, and is taught by one or more professors, and in which students can enroll
    /// </summary>
    public class Course
    {
        // We will use the Entity Framework to build the Model
        // https://learn.microsoft.com/en-us/ef/

        [Key] // PK
        public int Id { get; set; }

        /// <summary>
        /// Name of the Subject
        /// </summary>
        [Required(ErrorMessage = "o {0} é de preenchimento obrigatório")]
        [StringLength(30)]
        [Display(Name = "Nome da Disciplina")]
        public string Name { get; set; } = "";

        /// <summary>
        /// Curricular year of the subject
        /// </summary>
        public int CurricularYear { get; set; }

        /// <summary>
        /// Semester of the subject
        /// </summary>
        public int Semester { get; set; }

        /* ****************************************
         * Building the Relationships
         * *************************************** */

        // relationship 1-N

        /// <summary>
        /// FK for the course to which the subject belongs
        /// </summary>
        [ForeignKey(nameof(Degree))]
        [Display(Name = "Curso")]
        public int DegreeFK { get; set; } // FK for the Degree

        /// <summary>
        /// FK for the course to which the subject belongs
        /// </summary>
        [ValidateNever]
        public Degree Degree { get; set; } = null!; // FK for the Degree

        // relationship M-N, WITHOUT attributes in the relationship
        /// <summary>
        /// List of professors who teach the subject
        /// </summary>
        public ICollection<Professor> ProfessorsList { get; set; } = [];

        // relationship N-M, WITH attributes in the relationship
        /// <summary>
        /// List of students enrolled in the subject
        /// </summary>
        public ICollection<Registration> RegistrationsList { get; set; } = [];
    }
}
