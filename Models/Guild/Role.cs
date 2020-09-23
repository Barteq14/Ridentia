﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Guild
{
    public class Role
    {
        [Key]
        [Required]
        public int RoleID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(100)]
        public string NameRole { get; set; }
        public int GuildID { get; set; }
        [ForeignKey("GuildID")]
        public virtual Guild Guild { get; set; }
        public int MemberID { get; set; }
        [ForeignKey("MemberID")]
        public virtual Member Member { get; set; }
    }
}