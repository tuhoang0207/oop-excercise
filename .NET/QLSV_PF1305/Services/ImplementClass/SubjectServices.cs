using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Services.interfaces;

namespace Services.ImplementClass
{
    public class SubjectServices : SuperClass<MonHoc>, ISubject<MonHoc>, superInterfaces<MonHoc>
    {
        public override void Create(MonHoc model)
        {
            MonHoc m = new MonHoc();

            System.Console.WriteLine("enter id mon hoc ");
            m.id = Convert.ToInt32(Console.ReadLine());
        }

        public override int Delete(int id)
        {
            throw new NotImplementedException();
        }

        

        public MonHoc GetById(MonHoc model)
        {
            throw new NotImplementedException();
        }

        public MonHoc GetById(int id)
        {
            throw new NotImplementedException();
        }

        public MonHoc getByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<MonHoc> getBySemester(string semester)
        {
            throw new NotImplementedException();
        }

        public List<MonHoc> getByState(string state)
        {
            throw new NotImplementedException();
        }

        public List<MonHoc> listAll()
        {
            throw new NotImplementedException();
        }

   

        public override void Update(MonHoc model, MonHoc model2)
        {
            throw new NotImplementedException();
        }

        List<MonHoc> superInterfaces<MonHoc>.getByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}