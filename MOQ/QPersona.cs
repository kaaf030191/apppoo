using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOQ
{
    public class QPersona : IPersona
    {
        public List<Persona> GetByEdad()
        {
            List<Persona> persona = new List<Persona>();
            persona.Add(new Persona { nombre = "david", direccion = "av Abancay", edad = 23,telefono="987654321" });
            persona.Add(new Persona { nombre = "juan", direccion = "jr junin", edad = 23, telefono = "983332222" });
            persona.Add(new Persona { nombre = "alex", direccion = "jr puno", edad = 23, telefono = "987091298" });
            persona.Add(new Persona { nombre = "carlos", direccion = "jr lima", edad = 22, telefono = "983221100" });
            persona.Add(new Persona { nombre = "alfredo", direccion = "av canada", edad = 23, telefono = "980992288" });
            persona.Add(new Persona { nombre = "david2", direccion = "psj medrano", edad = 22, telefono = "909221111" });

            throw new NotImplementedException();
        }
    }
}
