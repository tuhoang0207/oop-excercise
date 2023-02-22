using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Services.interfaces;

namespace Services.ImplementClass
{
    public class MarkServices : SuperClass<Diem>, superInterfaces<Diem>, IMark<Diem>
    {
        public override void Create(Diem model)
        {
            throw new NotImplementedException();
        }

        public override int Delete(int id)
        {
            throw new NotImplementedException();
        }

      

        public Diem GetById(Diem model)
        {
            throw new NotImplementedException();
        }

        public Diem GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Diem> getByIdSubject(int idSJ)
        {
            throw new NotImplementedException();
        }

        public List<Diem> getByIdSV(int idSV)
        {
            throw new NotImplementedException();
        }

        public List<Diem> getByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<Diem> listAll()
        {
            throw new NotImplementedException();
        }

        public override void Update(Diem model)
        {
            throw new NotImplementedException();
        }
    }
}