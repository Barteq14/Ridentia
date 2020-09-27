using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Item
{
    public class CurrentEquipment_Item
    {
        [Key]
        [Required]
        public int CurrentEquipmentItemID { get; set; }
        public int? ItemID { get; set; }
        [ForeignKey("ItemID"), Column(Order = 0)]
        public virtual Item Item { get; set; }
        public int? CurrentEquipmentID { get; set; }
        [ForeignKey("CurrentEquipmentID"), Column(Order = 1)]
        public virtual CurrentEquipment CurrentEquipment { get; set; }
    }
}
