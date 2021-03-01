﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Models
{
    public class LeaveTypeViewModel
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        [Display(Name="Default Number of Days")]
        [Range(1,105, ErrorMessage ="Please Enter A Valid Number")]
        public int DefaultDays { get; set; }
        [Display(Name="Date Created")]
        public DateTime? DateCreated { get; set; }
    }
}
