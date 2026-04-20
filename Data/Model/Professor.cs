namespace lab2.Data.Model
{
    /// <summary>
    /// Professor who teaches Subjects
    /// </summary>
    public class Professor : MyUser
    {
        // ############################################################
        // Relationship
        // ############################################################
        /// <summary>
        /// List of subjects taught by the professor
        /// </summary>
        public ICollection<Course> CoursesList { get; set; } = [];
    }
}
