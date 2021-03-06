﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Laborator8App.Models;

namespace Laborator8App.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }
        [Required(ErrorMessage = "Continutul comentariului este obligatoriu")]
        [DataType(DataType.MultilineText)]
        public string Content { get; set; }
        //trebuie adaugat user id 
        public DateTime Date { get; set; }
        public int TaskId { get; set; }
        public string UserName { get; set;  }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual TaskClass Task { get; set; }
    }
}