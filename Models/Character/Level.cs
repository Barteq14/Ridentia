using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Character
{
    public class Level
    {
        [Key]
        [Required]
        public int LevelID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(100)]
        public string NameLevel { get; set; }
        [Required]
        [Range(0,500)]
        public int RequiredExp { get; set; }
        [Required]
        [Range(0, 500)]
        public int ReceivedPoint { get; set; }
        public virtual ICollection<Character> Characters { get; set; }

    }
}
