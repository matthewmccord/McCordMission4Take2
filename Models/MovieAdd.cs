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
        public int MovieID { get; set; }
        
        [Required(ErrorMessage = "A valid Title is required")]
        public string Title { get; set; }
        [Required(ErrorMessage = "A valid director is required")]
        public string Director { get; set; }
        [Required(ErrorMessage = "A valid rating is required")]
        public string Rating { get; set; }
       
        public bool Edited { get; set; }
        public string Lent_To { get; set; }
        [StringLength(25)]
        public string Note { get; set; }
        
        //Build a Foreign Key Relationship
        [Required]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
