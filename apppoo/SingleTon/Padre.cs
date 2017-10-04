using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apppoo.SingleTon
{
    class Padre
    {
        protected Interface1 interface1;
        protected Interface2 interface2;

        public Padre()
        {

        }
        public Padre(Interface1 _interface1)
        {
            this.interface1 = _interface1;
        }
        public Padre(Interface2 _interface2)
        {
            this.interface2 = _interface2;
        }
        public void saludar()
        {
            this.interface1.saludar();
        }
        public void insertar()
        {
            this.interface2.insertar();
        }
    }
}
