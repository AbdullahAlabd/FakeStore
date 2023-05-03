using FakeStore.DataAccess.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeStore.DataAccess.Entities
{
    public class Cart : BaseEntity
    {
        public ICollection<Item> Items { get; set; }
        [Required]
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
