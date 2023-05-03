using FakeStore.DataAccess.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FakeStore.DataAccess.Entities
{
    public class User : BaseEntity
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [RegularExpression("[a-zA-Z0-9]{0,16}")]
        public string Username { get; set; }
        [Required]
        [StringLength(128)]
        public string Password { get; set; } // TODO: Encrypt with a salt
        [Required]
        [StringLength(128)]
        public string FirstName { get; set; }
        [Required]
        [StringLength(128)]
        public string LastName { get; set; }
        [Phone]
        public string? MSISDN { get; set; }
        [StringLength(128)]
        public string? Country { get; set; }
        [StringLength(128)]
        public string? City { get; set; }
    }
}
