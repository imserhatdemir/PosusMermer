using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Plates
    {
        [Key]
        public int PlatesID { get; set; }
        [StringLength(150)]
        public string PlatesName { get; set; }
        [StringLength(300)]
        public string PlatesAbout { get; set; }
        [StringLength(300)]
        public string Image { get; set; }
    }
}
