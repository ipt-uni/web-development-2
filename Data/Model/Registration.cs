using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace lab2.Data.Model
{
    /// <summary>
    /// Links students to courses. Composite key prevents duplicate registrations.
    /// </summary>
    [PrimaryKey(nameof(StudentFK), nameof(CourseFK))]
    public class Registration
    {
        /// <summary>
        /// Date and time of registration.
        /// </summary>
        public DateTime RegistrationDate { get; set; }

        /// <summary>
        /// Foreign key to Student entity.
        /// </summary>
        [ForeignKey(nameof(Student))]
        public int StudentFK { get; set; }

        /// <summary>
        /// Navigation property to Student.
        /// </summary>
        public Student student { get; set; } = null!;

        /// <summary>
        /// Foreign key to Course entity.
        /// </summary>
        [ForeignKey(nameof(Course))]
        public int CourseFK { get; set; }

        /// <summary>
        /// Navigation property to Course.
        /// </summary>
        public Course Course { get; set; } = null!;
    }
}

/*
 * before [Key] meant primary key.
 * but new entity framework version requires the [PrimaryKey] attribute to function.
 */
