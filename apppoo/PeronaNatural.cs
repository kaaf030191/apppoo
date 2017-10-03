using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apppoo
{
    class PeronaNatural
    {
        private string apellido;
        private int dni;
        private string fechanacimiento;
        private string sexo;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
       

        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
       

        public string Fechanacimiento
        {
            get { return fechanacimiento; }
            set { fechanacimiento = value; }
        }
        

        public string Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
    }
}
