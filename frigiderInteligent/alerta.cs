using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace frigiderInteligent
{
    public class alerta
    {
        public string idalerta
        {
            get;
            set;
        }
        public string idprodus
        {
            get;
            set;
        }
        public string idpersoana
        {
            get;
            set;
        }
         public alerta()
        { 
            
        }
         public alerta(string pidalerta, string pidprodus, string pidpersoana )
         {
             idalerta = pidalerta;
             idprodus = pidprodus;
             idpersoana = pidpersoana;

         }
    }
}
