using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace Conti.Massimiliano._5I.PersoneXMLWeb
{
    public class Persona
    {
        public string Nome_C { get; set; }
        public string Cognome_C { get; set; }
        public string Indirizzo_C { get; set; }
        public string Number_C { get; set; }
        public Persona(XElement e)
        {
            Nome_C = e.Attribute("Nome").Value;
            Cognome_C = e.Attribute("Cognome").Value;
            Indirizzo_C = e.Attribute("Indirizzo").Value;
            Number_C = e.Attribute("Numero").Value;
        }
    }
}
