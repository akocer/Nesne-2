using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyg04.Models
{
    public class Work
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }

        public double Price { get; set; }

        public int CustomerId { get; set; }

        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual Customer Customer { get; set; }
    }
}
