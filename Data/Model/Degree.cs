using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace lab2.Data.Model
{
    [PrimaryKey(nameof(Id))]
    public class Degree
    {
        public int Id { get; set; }

        [StringLength(100)]
        [Display(Name = "Degree Name")]
        public String Name { get; set; } = "";

        [StringLength(50)]
        [Display(Name = "Logo Type")]
        public String? LogoType { get; set; } = null;
    }
}
