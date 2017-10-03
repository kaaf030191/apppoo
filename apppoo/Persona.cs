using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apppoo
{
    class Persona
    {
        private string nombre;
        private string dirección;
        private string telefono;
        private string correo_electronico;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public string Dirección
        {
            get { return dirección; }
            set { dirección = value; }
        }
        
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        
        public string Correo_electronico
        {
            get { return correo_electronico; }
            set { correo_electronico = value; }
        }
    }
}
