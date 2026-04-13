using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace lab2.Data.Model
{
    [PrimaryKey(nameof(Id))]
    public class MyUser
    {
        public int Id { get; set; }

        [StringLength(50)]
        [Display(Name = "User Name")]
        public string Name { get; set; } = "";

        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [StringLength(17)]
        [DataType(DataType.PhoneNumber)]
        public string CellPhone { get; set; } = "";

        [StringLength(50)]
        public string? UserID = null;
    }
}
