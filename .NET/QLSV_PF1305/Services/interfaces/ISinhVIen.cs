using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.interfaces
{
    public interface ISinhVIen<V>
    {
        List<V> GetByAddress(string address);
        List<V> GetByEmail(string email);
    }
}