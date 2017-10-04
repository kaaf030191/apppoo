using System;
using System.Collections.Generic;

namespace apppoo
{
    class EntityPersona
    {
        public virtual void insertarPersonaNatural(PersonaNatural persona, ref List<PersonaNatural> lista) { }
        public virtual void insertarPersonaJuridica(PersonaJuridica persona, ref List<PersonaJuridica> lista) { }
    }
}
