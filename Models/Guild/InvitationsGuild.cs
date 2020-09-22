using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Guild
{
    public class InvitationsGuild
    {
        [Key]
        [Required]
        public int InvitationsGuildID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(100)]
        public string Status { get; set; }
        public int GuildID { get; set; }
        [ForeignKey("GuildID")]
        public virtual Guild Guild { get; set; }
        public int CharacterID { get; set; }
        [ForeignKey("CharacterID")]
        public virtual Character.Character Character { get; set; }

    }
}
