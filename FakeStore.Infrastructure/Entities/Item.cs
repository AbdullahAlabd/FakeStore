using FakeStore.DataAccess.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeStore.DataAccess.Entities
{
    public class Item : BaseEntity
    {
        [Required]
        public int ProductId { get; set; }
        public Product Product { get; set; }
        [Range(1, 1000)]
        public int Quantity { get; set; }
    }
}
