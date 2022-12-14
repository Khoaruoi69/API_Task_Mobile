namespace API_Task.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? Status { get; set; }
        public bool IsCompleted { get; set; }


    }
}
