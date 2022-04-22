using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Project
    {
        [Key]
        public int ProjectID { get; set; }
        [StringLength(100)]
        public string ProjectName { get; set; }
        [StringLength(300)]
        public string Image { get; set; }
        [StringLength(300)]
        public string Map { get; set; }
    }
}
