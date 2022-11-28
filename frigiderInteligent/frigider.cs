using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace frigiderInteligent
{
    public class frigider
    {
        public string marca
        {
            get;
            set;
        }
        public string model
        {
            get;
            set;
        }
        public string idfrigider
        {
            get;
            set;
        }
        public string idpersoana
        {
            get;
            set;
        }
        public List<produs> produse = new List<produs>();
        public List<alerta> alerte = new List<alerta>();
        public frigider()
        { 
            
        }
       
    }
}
