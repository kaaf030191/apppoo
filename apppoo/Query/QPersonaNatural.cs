using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using apppoo.Object;

namespace apppoo.Query
{
    public class QPersonaNatural:QPersona
    {
        public override void insertarPersonaNatural(PersonaNatural personaNatural, ref List<PersonaNatural> listaPersonaNatural)
        {
            listaPersonaNatural.Add(personaNatural);
        }
        public override void ListarPersona(List<PersonaNatural> listaPersonaNatural, List<PersonaJuridica> listaPersonaJuridica, ref DataGridView dgv)
        {
            dgv.DataSource = listaPersonaNatural;
        }
 
    }
}
