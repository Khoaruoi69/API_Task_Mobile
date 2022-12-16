using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace API_Task.Models
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [MaxLength(200, ErrorMessage = "UserName cannot be more than 200 characters ")]
        public string UserName { get; set; }
        [Required]
        [StringLength(10, MinimumLength = 3, ErrorMessage = "Password must be between 3 and 10 characters")]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        
        [MaxLength(100, ErrorMessage = "Phone number cannot be more than 15 numbers")]
        public string Phone { get; set; }
        
        [MaxLength(2000, ErrorMessage = "Description must be more than 2000 characters")]
        public string Profile { get; set; }
        public bool Gender { get; set; }
        public bool IsActived { get; set; }
        public bool IsAdmin { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Todo> Todos { get; set; }
    }
}
