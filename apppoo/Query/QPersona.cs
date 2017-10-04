using apppoo.Object;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apppoo.Query
{
    public class QPersona
    {
        public virtual void insertar()
        {
            MessageBox.Show("Insertar");
        }

        public virtual void insertarPersonaNatural(PersonaNatural personaNatural, ref List<PersonaNatural> listaPersonaNatural) { }
        public virtual void insertarPersonaJuridica(PersonaJuridica personaJurica, ref List<PersonaJuridica> listaPersonaJuridica) { }

        public virtual void ListarPersona(List<PersonaNatural> ListapersonaNatural, List<PersonaJuridica>ListaPersonaJuridica, ref DataGridView dgv) { }

    }
}
