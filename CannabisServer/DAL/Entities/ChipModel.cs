using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("ChipModels",Schema = "Inventory")]
    public class ChipModel
    {
        [Key]
        public int ChipModelId { get; set; }
        [StringLength(100,ErrorMessage = "Manufacturer no more than 100 characters.")]
        public string Manufacturer { get; set; } // Nhà sản xuất (ví dụ: "Samsung", "Osram")
        [StringLength(100, ErrorMessage = "ModelChip no more than 100 characters.")]
        public string ModelChip { get; set; } // Tên model chip (ví dụ: "301H", "301L")
        [StringLength(50, ErrorMessage = "Generation no more than 50 characters.")]

        public string Generation { get; set; } // Thế hệ (nếu có, ví dụ: "Gen 2", "Gen 3")
        [Column(TypeName ="decimal(5,2")]
        public decimal Efficiency { get; set; } // Hiệu suất (lumen trên watt, tùy chọn)

        // Điều hướng quan hệ (Navigation Property)
        public virtual ICollection<GrowLight> GrowLights { get; set; } // Một model chip có thể dùng trong nhiều thiết bị chiếu sáng
    }
}
