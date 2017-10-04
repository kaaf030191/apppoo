using apppoo.Object;
using System.Collections.Generic;
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

        public virtual void listarPersona(List<PersonaNatural> listaPersonaNatural, List<PersonaJuridica> listaPersonaJuridica, ref DataGridView dgv) { }
    }
}