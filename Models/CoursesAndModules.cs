namespace CoursesWebApp.Models
{
    public class CoursesAndModules
    {
        // CourseName, ModuleTitle, and Sequence read-only properties
        public string CourseName { get; }
        public string ModuleTitle { get; }
        public int Sequence { get; }

        // Constructor that initializes the fields behind the properties
        public CoursesAndModules(string courseName, string moduleTitle, int sequence)
        {
            this.CourseName = courseName;
            this.ModuleTitle = moduleTitle;
            this.Sequence = sequence;
        }

    }
}
