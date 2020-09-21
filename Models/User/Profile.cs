using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models
{
    public class Profile
    {
        [Key]
        [Required]
        public int ProfileID { get; set; }
        [Required]
        [Range(0,2)]
        public int AccountBan { get; set; }
    }
}
    