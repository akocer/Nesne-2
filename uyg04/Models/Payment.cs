using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyg04.Models
{
    public class Payment
    {
        public int Id { get; set; }
        public double Paid { get; set; }
        public int CustomerId { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
