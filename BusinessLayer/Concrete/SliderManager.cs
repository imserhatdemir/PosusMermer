using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class SliderManager
    {
        Repository<Slider> reposlider = new Repository<Slider>();

        public List<Slider> GetAll()
        {
            return reposlider.List();
        }

        public int SliderAdd(Slider p)
        {

            if (p.Description1 == "" || p.Description2 == "")
            {
                return -1;
            }
            return reposlider.Insert(p);
        }
        public Slider FindBlog(int id)
        {
            return reposlider.Find(x => x.SliderID == id);
        }
        public int DeleteSlider(int p)
        {
            Slider slider = reposlider.Find(x => x.SliderID == p);
            return reposlider.Delete(slider);
        }
    }
}
