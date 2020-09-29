using Gra_przegladarkowa.Models.Mission;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Mission
{
    public class Missions
    {
        [Key]
        [Required]
        public int MissionID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(150)]
        public string NameMission { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [MaxLength(999999999)]
        public string Description { get; set; }
        [Required]
        [Range(1,1000)]
        public int MissionLvl { get; set; }
        [Required]
        [Range(1, 99999999999)]
        public int RevardGold { get; set; }
        [Required]
        [Range(1, 99999999999)]
        public int RevardExp { get; set; }
        [Required]
        [Range(1,100)]
        public int RequiredQuantity { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(150)]
        public string Status { get; set; }
        public int CharacterID { get; set; }
        [ForeignKey("CharacterID")]
        public virtual Character.Character Character { get; set; }
        public int MonsterID { get; set; }
        [ForeignKey("MonsterID")]
        public virtual  Monster Monster { get; set; }

    }
}
