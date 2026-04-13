using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab2.Data.Model
{
    public class Student : MyUser
    {
        public int StudentNumber { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Tuition Fee")]
        [Column(TypeName = "decimal(8,2)")]
        public decimal TuitionFee { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Registration Date")]
        public DateTime Date { get; set; } = DateTime.Today;
    }
}
