using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace frigiderInteligent
{
    public class produs
    {
        public string idprodus
        {
            get;
            set;
        }
        public string denumire
        {
            get;
            set;
        }
        public string dataexpirarii
        {
            get;
            set;
        }
        public string dateprodus
        {
            get;
            set;
        }
         public produs()
        { 
            
        }
         public produs(string pidprod, string pdenumire, string pdataexpira, string pdateprodus)
         {
             idprodus = pidprod;
             denumire = pdenumire;
             dataexpirarii = pdataexpira;
             dateprodus = pdateprodus;
         }
    }
}
