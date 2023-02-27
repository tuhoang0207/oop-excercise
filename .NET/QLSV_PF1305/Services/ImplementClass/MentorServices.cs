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
            var result = listGV.Find(x => x.email.Equals(name));
            return result;
        }

        

 

        public GiangVien GetById(int id)
        {
            foreach (var p in listGV)
            {
                Console.WriteLine(p.id);
            }
            var result = listGV.Find(x => x.id == id);
            return result;
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
            return listGV.ToList();
        }

        public override void Update(GiangVien model,GiangVien model2)
        {
            int index = listGV.IndexOf(model);
            listGV[index] = model2;
        }

      

        GiangVien IMentor<GiangVien>.getByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}