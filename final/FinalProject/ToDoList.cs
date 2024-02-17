// Things need to be done


class ToDoList
{
    public List<Task> Tasks { get; set; }

    public ToDoList()
    {
        Tasks = new List<Task>();
    }

    public void AddTask(Task task)
    {
        Tasks.Add(task);
    }

    public void MarkTaskCompleted(Task task)
    {
        task.IsCompleted = true;
    }
}