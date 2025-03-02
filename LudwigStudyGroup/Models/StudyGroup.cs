using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LudwigStudyGroup.Models
{
	public class StudyGroup
	{
        [Display(Name = "StudentNumber")]
        public int StudentNumber { get; set; }
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Display(Name = "Surname")]
        public string Surname { get; set; }
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}