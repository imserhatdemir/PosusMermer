using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ProjectManager
    {
        Repository<Project> repoproject = new Repository<Project>();
        public List<Project> GetAll()
        {
            return repoproject.List();
        }
        public List<Project> GetProjectByID(int id)
        {
            return repoproject.List().Where(x => x.ProjectID == id).ToList();
        }
    }
}
