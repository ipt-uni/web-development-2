using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace lab2.Data.Model
{
    [PrimaryKey(nameof(StudentFK), nameof(CourseFK))]
    public class Registration
    {
        public DateTime RegistrationDate { get; set; }

        [ForeignKey(nameof(Student))]
        // [Key]
        public int StudentFK { get; set; }
        public Student student { get; set; } = null!;

        [ForeignKey(nameof(Course))]
        // [Key]
        public int CourseFK { get; set; }
        public Course Course { get; set; } = null!;
    }
}

/*
 * before [Key] meant primary key.
 * but new entity framework version requires the [PrimaryKey] attribute to function.
 */
