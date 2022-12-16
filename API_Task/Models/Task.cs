using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Task.Models
{
    public class Task
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(256, MinimumLength = 10, ErrorMessage = "Task name must be between 10 and 256 characters")]
        public string TaskName { get; set; }
        public int? isFinished { get; set; }
     
        public virtual Todo Todo { get; set; }
      

    }
}
