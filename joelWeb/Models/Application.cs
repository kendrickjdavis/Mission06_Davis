﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace joelWeb.Models
{
    public class Application
    {
        [Key]
        [Required]
        public int MovieID { get; set; }
        public string Category { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Director { get; set; }
        public string Rating { get; set; }
        public bool? Edited { get; set; }
        public string? Lent_to { get; set; }
        public string? Notes { get; set; }
    }
}
