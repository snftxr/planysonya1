
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
        public List<Task> Tasks 
        { 
            get; private set; 
            
        }
        public string Description { get; set; }
        public Project()
        {
            Tasks = new List<Task>();
        }
        public void ClearTasks()
        {
            Tasks.Clear();
        }
        public void AddTask(Task task)
        {
            Tasks.Add(task);
        }
        public Project(string name)
        {
            Name = name;
            Tasks = new List<Task>();
        }

        //public Project()
        //{}

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
        public string Name { get; set; }
    }
    internal class TextBox1
    {
        public static string Text { get; internal set; }
    }
    internal class TextBox2
    {
        public static string Text { get; internal set; }
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