﻿using System.ComponentModel.DataAnnotations;

namespace Luma.Models
{
    public class Tasks
    {
        [Key]
        public int Id { get; set; }

        // Project ID

        public string Title { get; set; }

        public string Description { get; set; }

        public string Status { get; set; }

        public DateTime Start_Date { get; set; }

        public DateTime End_Date { get; set; }

        // public string Media { get; set; }
    }
}