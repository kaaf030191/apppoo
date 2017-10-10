using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace repositorio
{
    public interface Ipersona<T>
    {
        List<T> GetByEdad();
    }
}
