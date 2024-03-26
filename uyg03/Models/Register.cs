using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uyg03.Models
{
    public class Register
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int LessonId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
