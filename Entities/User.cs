using System.Collections.Generic;

namespace Entities
{
    public class User : Entity
    {
        public virtual string FirstName { get; set; }

        public virtual string LastName { get; set; }

        public virtual ICollection<History> Histories { get; set; }
    }
}
