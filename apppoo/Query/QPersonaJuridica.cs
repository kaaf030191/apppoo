using apppoo.Object;
using System.Collections.Generic;
using System.Windows.Forms;

namespace apppoo.Query
{
    public class QPersonaJuridica : QPersona
    {
        public void insertarPersonaJuridica(PersonaJuridica personaJuridica, ref List<PersonaJuridica> listaPersonaJuridica)
        {
            listaPersonaJuridica.Add(personaJuridica);
        }

        public override void listarPersona(List<PersonaNatural> listaPersonaNatural, List<PersonaJuridica> listaPersonaJuridica, ref DataGridView dgv)
        {
            dgv.DataSource = listaPersonaJuridica;
        }
    }
}