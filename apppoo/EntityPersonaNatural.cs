using System.Collections;
using System.Collections.Generic;

namespace apppoo
{
    class EntityPersonaNatural : EntityPersona
    {
        
        public override void insertarPersonaNatural(PersonaNatural persona, ref List<PersonaNatural> lista)
        {
            lista.Add(persona);
        }
    }
}