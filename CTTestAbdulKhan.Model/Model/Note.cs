using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CTTestAbdulKhan.Model.Model
{
    public class Note
    {
        public int ID { get; set; }
        public string Notes { get; set; }
        public int ContactId { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
