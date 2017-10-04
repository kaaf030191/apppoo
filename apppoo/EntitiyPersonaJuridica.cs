using System;
using System.Collections;
using System.Collections.Generic;

namespace apppoo
{
    class EntitiyPersonaJuridica : EntityPersona
    {
        

        public override void insertarPersonaJuridica(PersonaJuridica persona, ref List<PersonaJuridica> lista)
        {
            lista.Add(persona);
        }
    }
}