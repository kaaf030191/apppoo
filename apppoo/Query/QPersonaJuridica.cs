using apppoo.Object;
using System.Collections.Generic;
using System.Windows.Forms;

namespace apppoo.Query
{
    public class QPersonaJuridica:QPersona
    {
        public override void insertarPersonaJuridica(PersonaJuridica personaJuridica, ref List<PersonaJuridica> listaPersonaJuridica)
        {
            listaPersonaJuridica.Add(personaJuridica);
        }
        public override void ListarPersona(List<PersonaNatural> ListaPersonaNatural, List<PersonaJuridica>listaPersonaJuridica , ref DataGridView dgv)
        {
            dgv.DataSource = listaPersonaJuridica;
        }
    }
}
