using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.interfaces
{
    public interface ISubject<V>
    {
        V getByName(string name);
        List<V> getBySemester(string semester);
        List<V> getByState(string state);

    }
}