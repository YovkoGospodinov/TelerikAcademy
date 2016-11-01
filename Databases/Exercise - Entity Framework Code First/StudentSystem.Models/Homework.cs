using System;
using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Models
{
    public class Homework
    {
        [Key]
        public int Id { get; set; }

        [MinLength(10)]
        public string Content { get; set; }

        public DateTime TimeSent { get; set; }
    }
}
