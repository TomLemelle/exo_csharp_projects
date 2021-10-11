using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace portfolio.Models
{
    public class Project
    {
        public int Id { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(500, MinimumLength = 15)]
        [Required]
        public string Description { get; set; }

        [Required]
        public string Image { get; set; }

        [Display(Name = "Release Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
