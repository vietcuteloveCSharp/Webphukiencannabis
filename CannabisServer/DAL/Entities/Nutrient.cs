﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
    [Table("Nutrients",Schema = "Inventory")]
    public class Nutrient
    {
        [Key]
        public int NutrientId { get; set; }
        [Required(ErrorMessage = "Id brand is required.")]
        public int BrandId {  get; set; }
        [Required(ErrorMessage = "Id nutrient type is required.")]

        public int NutrientTypeId {  get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(10,2")]
        public decimal Price {  get; set; }
        public int VolumeMl { get; set; }
        [StringLength(255,ErrorMessage = "Ingredients no more than 255 characters.")]
        public string Ingredients { get; set; }
        [StringLength(50,ErrorMessage = "NpkRatio no more than 50 characters.")]
        public string NpkRatio { get; set; }
        public bool IsOrganic { get; set; } = false;
        public string Description { get; set; }
        public DateTime? ExpirationDate { get; set; }
        [StringLength(255, ErrorMessage = "Storage instructions no more than 255 characters.")]
        public string StorageInstructions { get; set; }
        //navigation
        public virtual Brand Brand { get; set; }
        public virtual NutrientType NutrientType { get; set; }
        public virtual Product Product { get; set; }
         
    }
}
