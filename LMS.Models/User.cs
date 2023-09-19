﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LMS.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string Name { get; set; }
        //[Required]
        public string? Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public UserRole Role { get; set; }
        public virtual ICollection<Enrollment>? Enrollments { get; set; }
    }

    public enum UserRole
    {
        Admin,
        Instructor,
        User
    }
}
