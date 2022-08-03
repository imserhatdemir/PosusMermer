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
        public int AddProject(Project p)
        {

            if (p.ProjectName == "" || p.About1 == "" || p.About2 == "" || p.Map == "")
            {
                return -1;
            }
            return repoproject.Insert(p);
        }
        public Project FindProject(int id)
        {
            return repoproject.Find(x => x.ProjectID == id);
        }
        public int DeleteProject(int p)
        {
            Project blog = repoproject.Find(x => x.ProjectID == p);
            return repoproject.Delete(blog);
        }
        public int UpdateProject(Project p)
        {
            Project blog = repoproject.Find(x => x.ProjectID == p.ProjectID);
            blog.ProjectName = p.ProjectName;
            blog.About1 = p.About1;
            blog.About2 = p.About2;
            blog.Map = p.Map;
            blog.Image = p.Image;
            return repoproject.Update(blog);
        }
    }
}
