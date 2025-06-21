using Enum;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Enum.EnumableClass.EnumableClass;

namespace DAL.Entities
{
    [Table("Seeds",Schema = "Inventory")]       
    public class Seed
    {
        [Key]
        public int SeedId { get; set; }
        [Required(ErrorMessage ="Id breeder is required.")]
        public int BreederId {  get; set; }
        [Column(TypeName ="varchar(30)")]
        public string THCContent { get; set; }
        [Column(TypeName = "varchar(30)")]
        public string CBDContent {  get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public EStrainType StrainType { get; set; }
        [Required(ErrorMessage = "Id Classify is required.")]
        public int ClassifyId { get; set; }
        public int FloweringTimeDays { get; set; }
        [Column(TypeName = "decimal(5,2)")]
        public decimal Yield {  get; set; } //sản lượng
        [Column(TypeName = "nvarchar(20)")]
        [Required(ErrorMessage = "Difficulty is required.")]
        public EDifficulty  Difficulty { get; set; }
        [Column(TypeName = "decimal(10,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(3,2)")]
        public decimal IndicaPercentage {  get; set; }
        [Column(TypeName = "decimal(3,2)")]
        public decimal SativaPercentage { get; set; }
        public int TotalQuantity {  get; set; } 

        //navi
        public virtual Breeder Breeder { get; set; }
        public virtual Product Product { get; set; }
        public virtual Classification Classification { get; set; }

    }
}
