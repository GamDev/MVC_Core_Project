using System;
using System.ComponentModel.DataAnnotations;
namespace MVC1.Models
{
    public class SimpleForm
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter First Name")]
        public string? firstName { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Enter Last Name")]
        public string? lastName { get; set; }
    }

}

