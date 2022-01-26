using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace McCordMission4Take2.Models
{
    public class MovieAdd
    {
        [Key]
        [Required]
        public int ApplicationID { get; set; }

        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Director { get; set; }
        [Required]
        public string Rating { get; set; }
       
        public bool Edited { get; set; }
        public string Lent_To { get; set; }
        [StringLength(25)]
        public string Note { get; set; }
    }
}
