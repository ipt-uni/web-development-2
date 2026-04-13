namespace lab2.Data.Model
{
    /// <summary>
    /// Teacher entity. Inherits all properties from MyUser.
    /// </summary>
    public class Professor : MyUser
    {
        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
