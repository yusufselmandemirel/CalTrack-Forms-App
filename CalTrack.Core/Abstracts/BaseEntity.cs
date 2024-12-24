using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalTrack.Core.Enums;
namespace CalTrack.Core.Abstracts
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime CreateDate { get; set; }= DateTime.Now;

  

        public Status Status { get; set; } = Status.Created;
    }
}
