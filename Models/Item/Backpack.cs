using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Item
{
    public class Backpack
    {
        [Key]
        [Required]
        public int BackpackID { get; set; }
        public int CharacterID { get; set; }
        [ForeignKey("CharacterID")]
        public virtual Character.Character Character { get; set; }
        public virtual ICollection<Backpack_Item> Backpack_Items { get; set; }
    }
}
