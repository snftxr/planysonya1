
namespace planysonya1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
    public class Project
    {
        public string Name { get; set; }
        public List<Task> Tasks { get; set; }

        public Project(string name)
        {
            Name = name;
            Tasks = new List<Task>();
        }

        public Project()
        {
        }

        //public object Project { get; set; }
    }
    public class Task
    {
        public string Description { get; set; }
        public bool IsCompleted { get; set; }
        public static object Text { get; internal set; }

        public Task(string description)
        {
            Description = description;
            IsCompleted = false;
        }

        internal static void Clear()
        {
            throw new NotImplementedException();
        }
    }
    
    /* public class ProjectManager 
    {
        Projects
        LoadProjects() 
        SaveProjects() 
        AddProject() 
        UpdateProject() 
        DeleteProject()
    } */
}