using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Item
{
    public class CurrentEquipment
    {
        [Key]
        [Required]
        public int CurrentEquipmentID { get; set; }
        public virtual Character.Character Character { get; set; }
        public virtual ICollection<CurrentEquipment_Item> CurrentEquipment_Items { get; set; }
    
    }
}
