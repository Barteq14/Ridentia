using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Gra_przegladarkowa.Models.Guild
{
    public class Building
    {
        [Key]
        [Required]
        public int BuildingID { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [MaxLength(100)]
        public string NameBuilding { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [MaxLength(999999999)]
        public string Description { get; set; }
        [Required]
        [Range(0,1000)]
        public int Level { get; set; }
        [Required]
        [Range(0, 9999999999)]
        public int CostUpgrade { get; set; }
        [Required]
        [Range(0, 10000)]
        public int Power { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        [MaxLength(999999999)]
        public string PowerInfo { get; set; }
        [Required]
        [DataType(DataType.ImageUrl)]
        public string ImageBuilding { get; set; }
        public virtual ICollection<Guild_Building> Guild_Buildings { get; set; }

    }
}
