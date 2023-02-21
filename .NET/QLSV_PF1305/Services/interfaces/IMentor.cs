using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.interfaces
{
    public interface IMentor<V>
    {
        V getByName(string name);
        V getByPhone(string name);
        V getByEmail(string name);
        V getByMajors(string name);
    }
}