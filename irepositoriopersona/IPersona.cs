using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace irepositoriopersona
{
    public interface IPersona<T>
    {
        List<T> GetByEdad();
    }
}
