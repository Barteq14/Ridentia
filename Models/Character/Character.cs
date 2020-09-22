using Gra_przegladarkowa.Models.Guild;
using Gra_przegladarkowa.Models.Item;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Character
{
    public class Character
    {
        [Key]
        [Required]
        public int CharacterID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(150)]
        public string NameCharacter { get; set; }
        [Required]
        [Range(0,999999999)]
        public int FamePoint { get; set; }
        [Required]
        [Range(0, 999999999)]
        public int Gold { get; set; }
        public int MemberID { get; set; }
        [ForeignKey("MemberID")]
        public virtual Member Member { get; set; }
        public int LevelID { get; set; }
        [ForeignKey("LevelID")]
        public virtual Level Level { get; set; }
        public int ProfessionID { get; set; }
        [ForeignKey("ProfessionID")]
        public virtual Profession Profession { get; set; }
        public int CurrentEquipmentID { get; set; }
        [ForeignKey("CurrentEquipmentID")]
        public virtual CurrentEquipment CurrentEquipment { get; set; }
        public int BackpackID { get; set; }
        [ForeignKey("BackpackID")]
        public virtual Backpack Backpack { get; set; }
        public int WorkID { get; set; }
        [ForeignKey("WorkID")]
        public virtual Work Work { get; set; }
        public virtual ICollection<InvitationsGuild> InvitationsGuilds { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Friend> Friends { get; set; }
        public virtual ICollection<Statistic> Statistics { get; set; }
        public virtual ICollection<Mission.Missions> Missions { get; set; }
    }
}
