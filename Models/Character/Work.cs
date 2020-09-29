using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Character
{
    public class Work
    {
        [Key]
        [Required]
        public int WorkID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(150)]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [MaxLength(999999999)]
        public string Description { get; set; }
        [Required]
        [Range(1,10)]
        public int WorkTime { get; set; }
        [Required]
        [Range(1, 99999999999)]
        public int RevardGold { get; set; }
        [Required]
        [Range(1, 99999999999)]
        public int RevardExp { get; set; }
        public virtual ICollection<Character> Characters { get; set; }
    }
}
