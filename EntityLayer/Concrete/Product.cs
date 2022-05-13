using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }
        [StringLength(150)]
        public string Title { get; set; }
        public ICollection<Offer> offers { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Details { get; set; }
        [StringLength(200)]
        public string Image { get; set; }
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}
