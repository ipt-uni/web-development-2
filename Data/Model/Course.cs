using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace lab2.Data.Model
{
    /// <summary>
    /// Represents an academic course.
    /// </summary>
    [PrimaryKey(nameof(Id))]
    public class Course
    {
        /// <summary>
        /// Unique course identifier.
        /// </summary>
        [Display(Name = "Course ID")]
        public int Id { get; set; }

        /// <summary>
        /// Course name. Maximum 30 characters.
        /// </summary>
        [StringLength(30)]
        [Display(Name = "Course Name")]
        public String Name { get; set; } = "";

        /// <summary>
        /// Curricular year (1, 2, 3, 4).
        /// </summary>
        [Display(Name = "Curricular Year")]
        public int CurricularYear { get; set; }

        /// <summary>
        /// Semester number (1 or 2).
        /// </summary>
        [Display(Name = "Semester")]
        public int Semester { get; set; }
    }
}
