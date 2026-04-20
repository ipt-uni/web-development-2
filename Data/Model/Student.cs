using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Aulas.Data.Model {

   /// <summary>
   /// class that inherits all characteristics of MyUser,
   /// that is, has Id, Name, Email, etc.
   /// And, can have other specific characteristics of a student,
   /// such as, for example, the enrollment, the course they are taking, etc.
   /// </summary>
   public class Student:MyUser {


      /// <summary>
      /// Number assigned to each student, to identify them uniquely
      /// </summary>
      public int StudentNumber { get; set; }

      /// <summary>
      /// Tuition fee paid by the Student at the time of enrollment in the Degree
      /// </summary>
      // [Precision(9, 2)] // informs EF to create the attribute with 9 digits and 2, as decimal part
      public decimal TuitionFee { get; set; }

      /// <summary>
      /// Student enrollment date
      /// </summary>
      [Display(Name = "Data Matrícula")]
      [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
      [DataType(DataType.Date)]
      public DateTime RegistrationDate { get; set; } = DateTime.Now;


/* ****************************************
       * Building the Relationships
       * *************************************** */

      // relationship 1-N


      /// <summary>
      /// FK para o Degree
      /// </summary>
[ForeignKey(nameof(Degree))] // this annotation informs EF that the 'DegreeFK' attribute is an FK together with the 'Degree' attribute
       [Display(Name = "Curso")]
       public int DegreeFK { get; set; } // FK for the Degree
       [ValidateNever] // informs EF not to validate this attribute
       public Degree Degree { get; set; } = null!; // FK for the Degree



      // relationship N-M, with attributes in the relationship
      /// <summary>
      /// List of UCs in which the student is enrolled
      /// </summary>
      public ICollection<Registration> RegistrationsList { get; set; } = [];
   }
}
