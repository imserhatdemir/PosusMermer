using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Offer
    {
        [Key]
        public int OfferID { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Location { get; set; }
        public DateTime Date { get; set; }
        [StringLength(100)]
        public string No { get; set; }
        [StringLength(100)]
        public string Mail { get; set; }
        public int ProductID { get; set; }
        public virtual Product Product { get; set; }
    }
}
