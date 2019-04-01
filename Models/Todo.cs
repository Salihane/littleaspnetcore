using System;
using System.ComponentModel.DataAnnotations;

namespace Todo.Models
{
    public class TodoItem{
        public Guid Id { get; set; }
        
        [Required]
        public string Title { get; set; }
        public bool IsDone { get; set; }
        public DateTimeOffset? DueAt { get; set; }
    }
}