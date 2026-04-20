using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore;

namespace lab2.Data.Model
{
    /// <summary>
    /// Class of the relationship between students and subjects
    /// </summary>
    [PrimaryKey(nameof(StudentFK), nameof(CourseFK))] // Composite PK (EF Core >= 7)
    public class Registration
    {
        /// <summary>
        /// Date when the student enrolls in the subject
        /// </summary>
        [Display(Name = "Data Inscrição")]
        [DataType(DataType.Date)]
        public DateTime RegistrationDate { get; set; } = DateTime.Now.Date;

        // FK for Student
        //   [Key, Column(Order = 1)] ----> valid for EF <=6
        /// <summary>
        /// FK for the student who enrolls in the subject
        /// </summary>
        [ForeignKey(nameof(Student))] // this annotation informs EF that the 'StudentFK' attribute is an FK together with the 'Student' attribute
        [Display(Name = "Estudante")]
        public int StudentFK { get; set; }

        /// <summary>
        /// FK for the student who enrolls in the subject
        /// </summary>
        public Student Student { get; set; } = null!;

        // FK for Course
        //   [Key, Column(Order = 2)] ----> valid for EF <=6
        /// <summary>
        /// FK for the subject in which the student enrolls
        /// </summary>
        [ForeignKey(nameof(Course))] // this annotation informs EF that the 'CourseFK' attribute is an FK together with the 'Course' attribute
        [Display(Name = "Disciplina")]
        public int CourseFK { get; set; }

        /// <summary>
        /// FK for the subject in which the student enrolls
        /// </summary>
        public Course Course { get; set; } = null!;
    }
}
