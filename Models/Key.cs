using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Key : BaseEntity
    {
        public string KeyName { get; set; }
        public float? Default { get; set; } 
    }
}
