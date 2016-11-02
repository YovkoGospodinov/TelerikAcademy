﻿using System;
using System.ComponentModel.DataAnnotations;

namespace StudentSystem.Models
{
    public class Homework
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(10)]
        public string Content { get; set; }

        public DateTime TimeSent { get; set; }

        public virtual int CourseId { get; set; }

        public virtual Course Course { get; set; }

        public virtual int StudentId { get; set; }

        public virtual Student Student { get; set; }
    }
}
