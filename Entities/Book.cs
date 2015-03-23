using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities
{
    public class Book : Entity
    {
        public virtual string Title { get; set; }

        public virtual string Description { get; set; }

        [ForeignKey("Category")]
        public virtual int CategoryId { get; set; }

        public virtual Category Category { get; set; }
    }
}
