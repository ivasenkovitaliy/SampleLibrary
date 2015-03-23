using System;
using System.Collections.Generic;

namespace Entities
{
    public class Category : Entity
    {
        public virtual string Name { get; set; }

        public virtual ICollection<Book> Books { get; set; } 
    }
}
