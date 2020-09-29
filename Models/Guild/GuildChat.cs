using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Guild
{
    public class GuildChat
    {
        [Key]
        [Required]
        public int GuildChatID { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [MaxLength(999999999)]
        public string Message { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yy H:mm:ss zzz}")]
        public DateTime MessageDate { get; set; }
        public int MemberID { get; set; }
        [ForeignKey("MemberID")]
        public virtual Member Member { get; set; }
        

    }
}
