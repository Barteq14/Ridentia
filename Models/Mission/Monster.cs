using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Mission
{
    public class Monster
    {
        [Key]
        [Required]
        public int MonsterID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(150)]
        public string NameMonster { get; set; }
        [Required]
        [Range(1, 1000)]
        public int MonsterLvl { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageMonsterName { get; set; }
        [Required]
        [Range(1, 1000)]
        public int Damage { get; set; }
        [Required]
        [Range(1, 1000)]
        public int Strenght { get; set; }
        [Required]
        [Range(1, 1000)]
        public int Armor { get; set; }
        [Required]
        [Range(1, 1000)]
        public int BlockHit { get; set; }
        [Required]
        [Range(1, 1000)]
        public int Resistance { get; set; }
        [Required]
        [Range(1, 1000)]
        public int Inteligence { get; set; }
        [Required]
        [Range(1, 1000)]
        public int Vitality { get; set; }
        [Required]
        [Range(1, 9999999999)]
        public int Hp { get; set; }
        [Required]
        [Range(1, 9999999999)]
        public int DeathRevardGold { get; set; }
        [Required]
        [Range(1, 9999999999)]
        public int DeathRevardExp { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime TimeRespown { get; set; }
        public virtual ICollection<Monster> Monsters { get; set; }

    }
}
