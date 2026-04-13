using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace lab2.Data.Model
{
    /// <summary>
    /// Represents an academic degree program (e.g., Bachelor's, Master's).
    /// </summary>
    [PrimaryKey(nameof(Id))]
    public class Degree
    {
        /// <summary>
        /// Unique identifier for the degree. Auto-generated.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Official name of the degree. Maximum 100 characters.
        /// </summary>
        [StringLength(100)]
        [Display(Name = "Degree Name")]
        public String Name { get; set; } = "";

        /// <summary>
        /// File extension of degree logo image (png, jpg, svg). Nullable.
        /// </summary>
        [StringLength(50)]
        [Display(Name = "Logo Type")]
        public String? LogoType { get; set; } = null;
    }
}
