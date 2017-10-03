using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apppoo
{
    class PersonaNatural
    {
        private string apellido;
        private string dni;
        private string fecha_nacimiento;
        private string sexo;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        
        public string Fecha_nacimiento
        {
            get { return fecha_nacimiento; }
            set { fecha_nacimiento = value; }
        }
        
        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }

    }
}
