using System.ComponentModel.DataAnnotations;

namespace ToDoListApp.Models
{
    public class ToDoItem
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsComplete { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DueDate { get; set; }
    }

}
