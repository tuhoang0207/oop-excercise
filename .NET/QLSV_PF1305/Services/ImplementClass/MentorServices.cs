using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Services.interfaces;

namespace Services.ImplementClass
{
    public class MentorServices : SuperClass<GiangVien>, superInterfaces<GiangVien>, IMentor<GiangVien>
    {
        public override void Create(GiangVien model)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public GiangVien getByEmail(string name)
        {
            throw new NotImplementedException();
        }

        public GiangVien GetById(int id)
        {
            throw new NotImplementedException();
        }

        public GiangVien getByMajors(string name)
        {
            throw new NotImplementedException();
        }

        public List<GiangVien> getByName(string name)
        {
            throw new NotImplementedException();
        }

        public GiangVien getByPhone(string name)
        {
            throw new NotImplementedException();
        }

        public List<GiangVien> listAll()
        {
            throw new NotImplementedException();
        }

        public override void Update(GiangVien model)
        {
            throw new NotImplementedException();
        }

        GiangVien IMentor<GiangVien>.getByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}