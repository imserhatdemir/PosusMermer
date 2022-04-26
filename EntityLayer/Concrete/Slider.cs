using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Slider
    {
        [Key]
        public int SliderID { get; set; }
        [StringLength(100)]
        public string Title1 { get; set; }
        [StringLength(100)]
        public string Description1 { get; set; }
        [StringLength(250)]
        public string Image1 { get; set; }
        [StringLength(100)]
        public string Title2 { get; set; }
        [StringLength(100)]
        public string Description2 { get; set; }
        [StringLength(300)]
        public string Image2 { get; set; }
        [StringLength(100)]
        public string Title3 { get; set; }
        [StringLength(100)]
        public string Description3 { get; set; }
        [StringLength(300)]
        public string Image3 { get; set; }
    }
}
