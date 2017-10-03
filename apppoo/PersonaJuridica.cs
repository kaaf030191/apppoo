using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apppoo
{
    class PersonaJuridica
    {
        private string ruc;
        private string url_pagina_web;

        public string Ruc
        {
            get { return ruc; }
            set { ruc = value; }
        }
     
        public string Url_pagina_web
        {
            get { return url_pagina_web; }
            set { url_pagina_web = value; }
        }
    }
}
