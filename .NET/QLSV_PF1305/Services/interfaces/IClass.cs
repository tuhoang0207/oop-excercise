using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.interfaces
{
    public interface IClass<V>
    {
        V GetById(int id);
        V GetByClassName(string className);
        List<V> GetByTeacher(string teacherName);
    }
}