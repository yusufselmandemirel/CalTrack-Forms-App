using CalTrack.Core.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalTrack.Core.Concretes
{
    public class Category:BaseEntity
    {
        public string Name { get; set; }
        public virtual ICollection<Food> Foods { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
