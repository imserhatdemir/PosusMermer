using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class About
    {
        [Key]
        public int AboutID { get; set; }
        [StringLength(150)]
        public string Title { get; set; }
        [StringLength(150)]
        public string Image { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(200)]
        public string ShortAbout { get; set; }
        [StringLength(200)]
        public string Instagram { get; set; }
        [StringLength(200)]
        public string Facebook { get; set; }
        [StringLength(200)]
        public string Twitter { get; set; }
        [StringLength(200)]
        public string Whatsapp { get; set; }
        [StringLength(200)]
        public string Mail { get; set; }
        [StringLength(500)]
        public string Map { get; set; }
    }
}
