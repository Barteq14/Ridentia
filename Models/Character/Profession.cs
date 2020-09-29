using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Character
{
    public class Profession
    {
        [Key]
        [Required]
        public int ProfessionID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(150)]
        public string NameProfession { get; set; }
        [DataType(DataType.MultilineText)]
        [MaxLength(999999999)]
        public string Description { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageProfessionName { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageProfessionName2 { get; set; }
        [Required]
        [Range(0, 1000)]
        public int Strenght { get; set; }
        [Required]
        [Range(0, 1000)]
        public int Dexterity { get; set; }
        [Required]
        [Range(0, 1000)]
        public int Armor { get; set; }
        [Required]
        [Range(0, 1000)]
        public int BlockHit { get; set; }
        [Required]
        [Range(0, 1000)]
        public int Resistance { get; set; }
        [Required]
        [Range(0, 1000)]
        public int Inteligance { get; set; }
        [Required]
        [Range(0, 1000)]
        public int Vitality { get; set; }
        [Required]
        [Range(0, 10000000)]
        public int Hp { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(150)]
        public string NameSpecialMove { get; set; }
        [Required]
        [Range(0, 500)]
        public int SpecialMoveTurnRequired { get; set; }
        public virtual ICollection<Character> Characters { get; set; }
        public virtual ICollection<Item.Item> Items { get; set; }
    }
}
