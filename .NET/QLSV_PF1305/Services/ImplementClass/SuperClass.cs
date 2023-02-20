using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Services.ImplementClass
{
    abstract public class SuperClass<Models>
    {
        abstract public void Create(Models model);
        abstract public void Update(Models model);
        abstract public void Delete(int id);
    }
}