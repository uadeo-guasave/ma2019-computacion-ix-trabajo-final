using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApi.Models
{
    public class Role
    {
        public int Id { get; set; }
        [MaxLength(20), Required]
        public string Name { get; set; }
        [Required, MaxLength(200)]
        public string Description { get; set; }
        [Required]
        public int Level { get; set; }
        public List<User> Users { get; set; }
    }
}