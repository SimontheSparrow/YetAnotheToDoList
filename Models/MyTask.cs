using System.ComponentModel.DataAnnotations;

namespace YetAnotheToDoList.Models
{
    public class MyTask
    {
        
        public int Id { get; set; }
        [Required]

        public string TaskName { get; set; }
        public string Description { get; set; }
        [Required]

        public DateTime WhenTodo { get; set; }
        [Required]

        public bool Done { get; set; }

    }
}
