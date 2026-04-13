using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab2.Data.Model
{
    /// <summary>
    /// Student entity. Inherits from MyUser.
    /// </summary>
    public class Student : MyUser
    {
        /// <summary>
        /// Unique student ID number. Assigned at registration.
        /// </summary>
        public int StudentNumber { get; set; }

        /// <summary>
        /// Tuition fee amount. Stored as decimal(8,2).
        /// </summary>
        [DataType(DataType.Currency)]
        [Display(Name = "Tuition Fee")]
        [Column(TypeName = "decimal(8,2)")]
        public decimal TuitionFee { get; set; }

        /// <summary>
        /// Date student was registered. Defaults to today.
        /// </summary>
        [DataType(DataType.Date)]
        [Display(Name = "Registration Date")]
        public DateTime Date { get; set; } = DateTime.Today;
    }
}
