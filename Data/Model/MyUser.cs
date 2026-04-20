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
        [Required(ErrorMessage = "O {0} é de preenchimento obrigatório.")]
        [Display(Name = "Nome Completo")]
        public string Name { get; set; } = "";

        /// <summary>
        /// Data de nascimento
        /// </summary>
        [Display(Name = "Data Nascimento")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateOnly BirthDate { get; set; }

        /// <summary>
        /// User's mobile phone,
        /// </summary>
        [Display(Name = "Telemóvel")]
        [StringLength(19)]
        public string? CellPhone { get; set; }

        /// <summary>
        /// attribute to work as FK between the MyUser table
        /// and the Authentication table
        /// </summary>
        //        public string UserID { get; set; } = null!;
    }
}
