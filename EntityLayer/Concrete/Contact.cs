using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Contact
    {
        [Key]
        public int ContactID { get; set; }
        [StringLength(100)]
        public string ContactName { get; set; }
        [StringLength(100)]
        public string ContactMail { get; set; }
        [StringLength(100)]
        public string City { get; set; }
        [StringLength(100)]
        public string Title { get; set; }
        [StringLength(500)]
        public string Message { get; set; }
    }
}
