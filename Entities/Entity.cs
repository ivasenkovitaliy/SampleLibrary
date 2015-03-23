using System;
using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Entity
    {
        [Key]
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
