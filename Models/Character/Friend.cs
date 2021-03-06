﻿using System;
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
        public int? FriendID1 { get; set; }
        [ForeignKey("FriendID1"), Column(Order = 0)]
        public int? FriendID2 { get; set; }
        [ForeignKey("FriendID2"), Column(Order = 1)]
        public virtual Character Character { get; set; }
        public virtual Character Character2 { get; set; }

        /*
          public int? GuildID { get; set; }
        [ForeignKey("GuildID"),  Column(Order = 0)]
        public int? GuildID2 { get; set; }
        [ForeignKey("GuildID2"), Column(Order = 1)]
        public virtual Guild Guild { get; set; }
        public virtual Guild Guild2 { get; set; }
         */
    }
}
