using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Models;
using Services.interfaces;

namespace Services.ImplementClass
{
    public class sinhVienServices : SuperClass<SinhVien>,ISinhVIen<SinhVien>,superInterfaces<SinhVien>
    {
        List<SinhVien> listSV = new List<SinhVien>();
        public override void Create(SinhVien model)
        {
            listSV.Add(model);
        }

        public override int Delete(int id)
        {
            var result = this.GetById(id);
            if(result != null) {
                listSV.Remove(result);
                return 1;
            } 
            return 0;
        }

        public List<SinhVien> GetByAddress(string address)
        {
            var result = listSV.Where(x => x.address == address).ToList();
            return result;
        }

        public List<SinhVien> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public SinhVien GetById(int model)
        {
            var result = listSV.Find(x => x.id == model);
            return result;
        }

        public List<SinhVien> getByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<SinhVien> listAll()
        {
          return listSV.ToList();
        }

        public override void Update(SinhVien model)
        {
            int index = listSV.IndexOf(model);
            listSV[index] = model;
        }

        public List<SinhVien> listByAddress(string address){
            return listSV.FindAll(x => x.address == address);
        }
    }
}