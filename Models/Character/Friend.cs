using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Character
{
    public class Friend
    {
        [Key]
        [Required]
        public int FriendID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(150)]
        public string Status { get; set; }
        public int FriendID1 { get; set; }
        [ForeignKey("FriendID1")]
        public virtual Character Character { get; set; }
        public int FriendID2 { get; set; }
        [ForeignKey("FriendID2")]
        public virtual Character Character2 { get; set; }
    }
}
