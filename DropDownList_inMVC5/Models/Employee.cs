using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DropDownList_inMVC5.Models
{
    public class Employee
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Country { get; set; }
    }
}