using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Guild
{
    public class Guild_Building
    {
        [Key]
        [Required]
        public int GuildBuildingID { get; set; }
        public int GuildID { get; set; }
        [ForeignKey("GuildID")]
        public int BuildingID { get; set; }
        [ForeignKey("BuildingID")]
        public virtual Guild Guild { get; set; }
        public virtual Building Building { get; set; }



    }
}
