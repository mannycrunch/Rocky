using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Rocky.Models
{
    [NotMapped]
    public class CatalogCourse
    {
        public string Label { get; set; }
        public string Value { get; set; }

        public CatalogCourse(string crsLabel, string crsValue)
        {
            Label = crsLabel;
            Value = crsValue;
        }
    }
}
