using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("CarbonFilters",Schema = "Inventory")]
    public class CarbonFilter
    {
        [Key]
        public int CarbonFilterId { get; set; }
        [Required(ErrorMessage = "CarbonFilter name is required.")]
        [StringLength(255, ErrorMessage = "CarbonFilter name cannot exceed 255 characters.")]
        public string CarbonFilterName { get; set; } // Tên bộ lọc
        [StringLength(150, ErrorMessage = "AirflowRate name cannot exceed 150 characters.")]
        public string AirflowRate { get; set; } // Lưu lượng không khí
        [Required(ErrorMessage = " Id Brand is required.")]
        public int BrandId { get; set; } // Mã thương hiệu
        public int Quantity { get; set; } =0;
        [Column(TypeName ="decimal(10,2)")]
        public decimal Price { get; set; } // Giá
        public string FilterMaterial { get; set; } // Chất liệu lọc
        [Column(TypeName = "decimal(4,2)")]
        public decimal Diameter { get; set; } // Đường kính
        [Column(TypeName = "decimal(4,2)")]
        public decimal Length { get; set; } // Chiều dài
        public int Lifespan { get; set; } // Tuổi thọ (giờ hoặc ngày)
        [Column(TypeName = "decimal(3,2)")]
        public decimal MinTemperature { get; set; } // Nhiệt độ tối thiểu
        [Column(TypeName = "decimal(3,2)")]
        public decimal MaxTemperature { get; set; } // Nhiệt độ tối đa
        public string Description { get; set; } // Mô tả sản phẩm
        public int WarrantyPeriod { get; set; }//thời gian bảo hành
        [StringLength(50, ErrorMessage = "ModelNumber name cannot exceed 50 characters.")]
        public string ModelNumber { get; set; } // Số model
        public DateTime CreatedAt { get; set; } =DateTime.Now;
        public DateTime UpdatedAt { get; set; }

        //navigation
        public virtual Brand Brand { get; set; }
        public virtual Product Product { get; set; }
    }
}
