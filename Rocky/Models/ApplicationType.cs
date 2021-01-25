using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    public class ApplicationType
    {
        [Key]
        public int Id { get; set; }

        [DisplayName("Application Type")]
        [Required]
        [MinLength(3, ErrorMessage = "Application Type must be as least 3 characters.")]
        public string Name { get; set; }

    }
}
