using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Task.Models
{
    public class Todo
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(256, MinimumLength = 10, ErrorMessage = "Todo Name must be between 10 and 256 characters")]
        public string TodoName { get; set; }
        public string Priority { get; set; }
        [Required]
        [MaxLength(2000, ErrorMessage = "Description cannot must be more than 2000 characters")]
        public string Description { get; set; }
        [Required]
        public DateTime DueDate { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Task> Tasks { get; set; }

    }
}
