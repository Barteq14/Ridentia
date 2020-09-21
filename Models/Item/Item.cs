using Gra_przegladarkowa.Models.Character;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Item
{
    public class Item
    {
        [Key]
        [Required]
        public int ItemID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(150)]
        public string NameItem { get; set; }
        [Required]
        [Range(0,500)]
        public int RequiredLvl { get; set; }
        [Required]
        [Range(0, 999999999999.9999)]
        public double ItemPrice { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        [MaxLength(150)]
        public string ImageItemName { get; set; }
        [Required]
        [Range(0, 10000)]
        public int Damage { get; set; }
        [Required]
        [Range(0, 10000)]
        public int Strenght { get; set; }
        [Required]
        [Range(0, 10000)]
        public int Armor { get; set; }
        [Required]
        [Range(0, 10000)]
        public int BlockHit { get; set; }
        [Required]
        [Range(0, 10000)]
        public int Resistance { get; set; }
        [Required]
        [Range(0, 10000)]
        public int Inteligence { get; set; }
        [Required]
        [Range(0, 10000)]
        public int Vitality { get; set; }
        [Required]
        [Range(0, 10000000)]
        public int Hp { get; set; }
        public int ProfessionID { get; set; }
        [ForeignKey("ProfessionID")]
        public virtual Profession Profession { get; set; }
        public int CategoryItemID { get; set; }
        [ForeignKey("CategoryItemID")]
        public virtual CategoryItem CategoryItem { get; set; }
        public virtual ICollection<Backpack_Item> Backpack_Items { get; set; }
        public virtual ICollection<CurrentEquipment_Item> CurrentEquipment_Items { get; set; }

    }
}
