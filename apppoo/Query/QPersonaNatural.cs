using apppoo.Object;
using System.Collections.Generic;
using System.Windows.Forms;

namespace apppoo.Query
{
    public class QPersonaNatural : QPersona
    {
        public override void insertarPersonaNatural(PersonaNatural personaNatural, ref List<PersonaNatural> listaPersonaNatural)
        {
            listaPersonaNatural.Add(personaNatural);
        }
    }
}