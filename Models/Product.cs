using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(40)]
        public string Name { get; set; }

        [Required]
        public float Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        [MaxLength(150)]
        public string Description { get; set; }

        [MaxLength(150)]
        public string vileDescription { get; set; }

        [ForeignKey("ManufacturerId")]
        public Manufacturer Manufacturer { get; set; }

        public int ManufacturerId { get; set; }
    }

}