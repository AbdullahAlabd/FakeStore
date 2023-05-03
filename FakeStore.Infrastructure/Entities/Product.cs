using FakeStore.DataAccess.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeStore.DataAccess.Entities
{
    public class Product : BaseEntity
    {
        [Required]
        public string Title { get; set; }
        [Required]
        [Range(0, 1000000.00)]
        public decimal Price { get; set; }
        [StringLength(128)]
        public string Category { get; set; }
        [StringLength(512)]
        public string? Description { get; set; }
        [StringLength(128)]
        public string? ImageURL { get; set; }        
    }
}
