using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyg04.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }


        [StringLength(50)]
        public string Email { get; set; }


        [StringLength(20)]
        public string Phone { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }

        public virtual List<Work> Works { get; set; }
        public virtual List<Payment> Payments { get; set; }
    }
}
