using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobTracking.Models
{
    public class Task
    {
        [Key]
        public int TaskId { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }  // Foreign key User modelin Id alan�na ba�l�

        public string? Description { get; set; }
        public string? Title { get; set; }

        public TaskStatus Status { get; set; }  // Enum kullanarak task durumunu y�net

        public virtual User? User { get; set; }  // Navigation property

        [DataType(DataType.Date)]
        public DateTime CreatedDate { get; set; }  // Olu�turulma tarihi
    }

    public enum TaskStatus
    {
        ToDo = 0,  // Yap�lacak
        InProgress = 1,  // Yap�l�yor
        Done = 2 // Tamamland�
    }
}