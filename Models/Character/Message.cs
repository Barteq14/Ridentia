using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Character
{
    public class Message
    {
        [Key]
        [Required]
        public int MessageID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(150)]
        public string Subject { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [MaxLength(999999999)]
        public string MessageText { get; set; }
        [Required]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yy H:mm:ss zzz}")]
        public DateTime SendTime { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(150)]
        public string Status { get; set; }
        public int Sender { get; set; }
        [ForeignKey("Sender")]
        public virtual Character Character { get; set; }
        public int Receiver { get; set; }
        [ForeignKey("Receiver")]
        public virtual Character Character2 { get; set; }
    }
}
