using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        [Key]
        public int BlogID { get; set; }
        [StringLength(50)]
        public string Title { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        [StringLength(50)]
        public string Image { get; set; }
    }
}
