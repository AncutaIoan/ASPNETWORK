﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Laborator8App.Models;
namespace Laborator8App.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }
        [Required(ErrorMessage = "Numele echipei este obligatoriu")]
        [StringLength(50, ErrorMessage = "Numele echipei nu poate avea mai mult de 50 caractere ")]
        public string TeamName { get; set; }

        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Project> Projects { get; set; }
    }
}