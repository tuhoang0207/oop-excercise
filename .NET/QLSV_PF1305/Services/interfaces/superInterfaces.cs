using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.interfaces
{
    public interface superInterfaces<V>
    {
        List<V> listAll();

        V GetById(int id);

        List<V> getByName(string name);
    }
}