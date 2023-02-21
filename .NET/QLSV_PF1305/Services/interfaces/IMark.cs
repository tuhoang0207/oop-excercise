using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.interfaces
{
    public interface IMark<V>
    {
        List<V> getByIdSV(int idSV);
        List<V> getByIdSubject(int idSJ);
    }
}