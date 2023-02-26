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
        List<GiangVien> listGV = new List<GiangVien>();
        public override void Create(GiangVien model)
        {
            listGV.Add(model);
        }

        public override int Delete(int id)
        {
            var result = this.GetById(id);
            if (result != null)
            {
                listGV.Remove(result);
                return 1;
            }
            return 0;
        }

        public GiangVien getByEmail(string name)
        {
            throw new NotImplementedException();
        }

        

        public GiangVien GetById(GiangVien model)
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
            return listGV.FindAll(x => x.name == name).ToList();
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