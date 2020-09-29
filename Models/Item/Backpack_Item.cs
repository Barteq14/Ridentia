using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Item
{
    public class Backpack_Item
    {
        [Key]
        [Required]
        public int BackpackItemID { get; set; }

        public int? ItemID { get; set; }
        [ForeignKey("ItemID"),Column(Order = 0)]
        public virtual Item Item { get; set; }
        public int? BackpackID { get; set; }
        [ForeignKey("BackpackID"), Column(Order = 1)]
        public virtual Backpack Backpack { get; set; }
    }
}
