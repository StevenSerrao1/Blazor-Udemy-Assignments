using ToDoList_Project.Components.Classes;

namespace ToDoList_Project.Components
{
    public class TaskRepo
    {
        public static List<Tasks> tasks = new List<Tasks>()
        {
            new Tasks() { Content = "Add a task", isCompleted = false }
        };

        public static List<Tasks> GetTasks()
        {
            return tasks;
        }
        public static void AddTask()
        {
            tasks.Insert(0, new Tasks() { Content = "Add a task", isCompleted = false });
        }
    }
}
