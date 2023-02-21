using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.interfaces
{
    public interface User<V>
    {
        List<V> getByFullname(string fullname);

        V getByPhone(string phone);

        V getByEmail(string email);
    }
}