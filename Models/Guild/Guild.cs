using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Guild
{
    public class Guild
    {
        [Key]
        [Required]
        public int GuildID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(100)]
        public string NameGuild { get; set; }
        [Required]
        [Range(0,50)]
        public int MaxMember { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [MaxLength(999999999)]
        public string Description { get; set; }
        [Required]
        [Range(0, 999999999)]
        public int GoldGuild { get; set; }
        [Required]
        [Range(0, 999999999)]
        public int FamePointGuild { get; set; }
        public virtual ICollection<Guild_Building> Guild_Buildings { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<Member> Members { get; set; }
        public virtual ICollection<RaportGuild> RaportGuilds { get; set; }
        public virtual ICollection<InvitationsGuild> InvitationsGuilds { get; set; }

    }
}
