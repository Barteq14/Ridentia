using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Character
{
    public class Statistic
    {
        [Key]
        [Required]
        public int StatisticID { get; set; }
        [Required]
        [Range(0,999999)]
        public int FightWin { get; set; }
        [Required]
        [Range(0, 999999)]
        public int FightLose { get; set; }
        [Required]
        [Range(0, 9999999999)]
        public int GoldStolen { get; set; }
        [Required]
        [Range(0, 9999999999)]
        public int Fame { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yy H:mm:ss zzz}")]
        public DateTime FightDate { get; set; }
        public int CharacterID { get; set; }
        [ForeignKey("CharacterID")]
        public virtual Character Character { get; set; }

    }
}
