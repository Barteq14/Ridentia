using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Guild
{
    public class Member
    {
        [Key]
        [Required]
        public int MemberID { get; set; }
        public int? GuildID { get; set; }
        [ForeignKey("GuildID"), Column(Order = 0)]
        public virtual Guild Guild { get; set; }
        public int? GuildChatID { get; set; }
        [ForeignKey("GuildChatID"), Column(Order = 1)]
        public virtual GuildChat GuildChat { get; set; }
        //Guild chat  - members  1 czat ma wielu członkow chyba
        public int? RoleID { get; set; }
        [ForeignKey("RoleID"), Column(Order = 2)]
        public virtual Role Role { get; set; }
        public int? CharacterID { get; set; }
        [ForeignKey("CharacterID"), Column(Order = 3)]
        public virtual Character.Character Character { get; set; }
        //public virtual ICollection<GuildChat> GuildChats { get; set; }
    }
}
