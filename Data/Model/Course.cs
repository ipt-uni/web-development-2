using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace lab2.Data.Model
{
    [PrimaryKey(nameof(Id))]
    public class Course
    {
        [Display(Name = "Course ID")]
        public int Id { get; set; }

        [StringLength(30)]
        [Display(Name = "Course Name")]
        public String Name { get; set; } = "";

        [Display(Name = "Curricular Year")]
        public int CurricularYear { get; set; }

        [Display(Name = "Semester")]
        public int Semester { get; set; }
    }
}
