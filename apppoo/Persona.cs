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
        private string direccion;
        private int telefono;
        private string correoelectronico;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
       

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }
        

        public int Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
     

        public string Correoelectronico
        {
            get { return correoelectronico; }
            set { correoelectronico = value; }
        }
    }
}
