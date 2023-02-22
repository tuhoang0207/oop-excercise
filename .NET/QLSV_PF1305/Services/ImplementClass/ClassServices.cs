using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Services.interfaces;

namespace Services.ImplementClass
{
    public class ClassServices : SuperClass<LopHoc>, IClass<LopHoc>, superInterfaces<LopHoc>
    {
        public override void Create(LopHoc model)
        {
            throw new NotImplementedException();
        }

        public override int Delete(int id)
        {
            throw new NotImplementedException();
        }

        public LopHoc GetByClassName(string className)
        {
            throw new NotImplementedException();
        }

       

        public LopHoc GetById(LopHoc model)
        {
            throw new NotImplementedException();
        }

        public LopHoc GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<LopHoc> getByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<LopHoc> GetByTeacher(string teacherName)
        {
            throw new NotImplementedException();
        }

        public List<LopHoc> listAll()
        {
            throw new NotImplementedException();
        }

        public override void Update(LopHoc model)
        {
            throw new NotImplementedException();
        }
    }
}