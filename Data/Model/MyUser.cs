using System.ComponentModel.DataAnnotations;

namespace lab2.Data.Model
{
    /// <summary>
    /// Class to represent the users of the application,
    /// that is, the data that identifies each user.
    /// </summary>
    public class MyUser
    {
        [Key] // PK
        public int Id { get; set; }

        /// <summary>
        /// Nome do utilizador
        /// </summary>
        [StringLength(50)]
        [Required(ErrorMessage = "The {0} is required.")]
        [Display(Name = "Full Name")]
        public string Name { get; set; } = "";

        /// <summary>
        /// Data de nascimento
        /// </summary>
        [Display(Name = "Birth Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateOnly BirthDate { get; set; }

        /// <summary>
        /// User's mobile phone,
        /// </summary>
        [Display(Name = "Mobile Phone")]
        [StringLength(19)]
        [RegularExpression(
            @"((\+)|(00)[0-9]{2,5})?[0-9]{4,13}",
            ErrorMessage = "Please enter a valid phone number"
        )]
        public string? CellPhone { get; set; }

        /// <summary>
        /// attribute to work as FK between the MyUser table
        /// and the Authentication table
        /// </summary>
        //        public string UserID { get; set; } = null!;
    }
}
