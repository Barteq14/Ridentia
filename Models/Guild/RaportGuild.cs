using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Guild
{
    public class RaportGuild
    {
        [Key]
        [Required]
        public int RaportGuildID { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yy H:mm:ss zzz}")]
        public DateTime DateRaportGuild { get; set; }
        [Required]
        [Range(0,99999999)]
        public int FightWin { get; set; }
        [Required]
        [Range(0, 99999999)]
        public int FightLose { get; set; }
        [Required]
        [Range(0, 99999999)]
        public int GoldStolen { get; set; }
        [Required]
        [Range(0, 99999999)]
        public int Fame { get; set; }
        //tutaj nie wiem (fight lose , fight win)
        public int GuildID1 { get; set; }
        [ForeignKey("GuildID1")]
        public virtual Guild Guild { get; set; }
        public int GuildID2 { get; set; }
        [ForeignKey("GuildID2")]
        public virtual Guild Guild2 { get; set; }
    }
}
