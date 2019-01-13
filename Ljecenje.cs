using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAssist_02
{
    class Ljecenje
    {
        public string naziv_bolesti;
        public DateTime datumi_svih_cijepljenja;
        public string naziv_cjepiva;
        public int trajanje_bolesti;
        public string prehrana_lijecenje;

        public string Naziv_bolesti
        {
            get { return naziv_bolesti; }
            set
            {
                if (value.Equals("")) throw new ArgumentException("Naziv bolesti je obavezno.", nameof(naziv_bolesti));
                naziv_bolesti = value;
            }
        }
        public DateTime Datumi_svih_cijepljenja
        {
            get { return datumi_svih_cijepljenja; }
            set
            {
              datumi_svih_cijepljenja = value;
            }
        }
        public string Naziv_cjepiva
        {
            get { return naziv_cjepiva; }
            set
            {
                if (value.Equals("")) throw new ArgumentException("Naziv cjepiva je obavezno.", nameof(naziv_cjepiva));
                naziv_cjepiva = value;
            }
        }
        public int Trajanje_bolesti
        {
            get { return trajanje_bolesti; }
            set
            {
                if (value.Equals("")) throw new ArgumentException("Trajanje bolesti je obavezno.", nameof(trajanje_bolesti));
                trajanje_bolesti = value;
            }
        }
        public string Prehrana_lijecenje
        {
            get { return Prehrana_lijecenje; }
            set
            {
                prehrana_lijecenje = value;
            }
        }
    }
}
