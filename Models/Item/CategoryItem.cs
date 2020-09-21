using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Item
{
    public class CategoryItem
    {
        [Key]
        [Required]
        public int CategoryItemID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(150)]
        public string NameCategoryItem { get; set; }
        public virtual ICollection<Item> Items { get; set; }

    }
}
