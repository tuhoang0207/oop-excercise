using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Models;
using Services.interfaces;

namespace Services.ImplementClass
{
    public class sinhVienServices : SuperClass<SinhVien>,ISinhVIen<SinhVien>,superInterfaces<SinhVien>
    {
        public override void Create(SinhVien model)
        {
            throw new NotImplementedException();
        }

        public override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<SinhVien> GetByAddress(string address)
        {
            throw new NotImplementedException();
        }

        public List<SinhVien> GetByEmail(string email)
        {
            throw new NotImplementedException();
        }

        public SinhVien GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<SinhVien> getByName(string name)
        {
            throw new NotImplementedException();
        }

        public List<SinhVien> listAll()
        {
            throw new NotImplementedException();
        }

        public override void Update(SinhVien model)
        {
            throw new NotImplementedException();
        }

        public List<SinhVien> listByAddress(string address){
            throw new NotImplementedException();
        }
    }
}