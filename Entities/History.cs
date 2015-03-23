using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class History: Entity
    {
        [ForeignKey("User")]
        public virtual int UserId { get; set; }

        public virtual User User { get; set; }

        [ForeignKey("Book")]
        public virtual int BookId { get; set; }

        public virtual Book Book { get; set; }

        public DateTime DateStart { get; set; }

        public DateTime DateEnd { get; set; }
    }
}
