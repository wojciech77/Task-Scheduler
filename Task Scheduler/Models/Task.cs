namespace Task_Scheduler.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; } = DateTime.Now;
        public DateTime DudDate { get; set; }
        public string Status { get; set; }
        public int Priority { get; set; }


    }
}
