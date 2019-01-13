using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmAssist_02
{
    class Tele
    {
        public DateTime porod;
        public string hb_teleta;
        public string spol_teleta;
        public string hb_bika;
        public DateTime datum_gonjenja;
        public decimal broj_pokusaja;
        public string opis;

        public DateTime Porod
        {
            get { return porod; }
            set
            {
                if (value.Equals("")) throw new ArgumentException("Upis poroda je obavezno.", nameof(porod));
                porod = value;
            }
        }
        public string HB_teleta
        {
            get { return hb_teleta; }
            set
            {
                if (value.Equals("")) throw new ArgumentException("HB_teleta je obavezno.", nameof(hb_teleta));
                hb_teleta = value;
            }
        }
        public string Spol_teleta
        {
            get { return spol_teleta; }
            set
            {
                if (value.Equals("")) throw new ArgumentException("Spol teleta je obavezno.", nameof(spol_teleta));
                spol_teleta = value;
            }
        }
        public string HB_bika
        {
            get { return hb_bika; }
            set
            {
                if (value.Equals("")) throw new ArgumentException("HB_bika je obavezno.", nameof(hb_bika));
                hb_bika = value;
            }
        }
        public DateTime Datum_gonjenja
        {
            get { return datum_gonjenja; }
            set
            {
                if (value.Equals("")) throw new ArgumentException("Datum_gonjenja je obavezno.", nameof(datum_gonjenja));
                datum_gonjenja = value;
            }
        }
        public decimal Broj_pokusaja
        {
            get { return broj_pokusaja; }
            set
            {
                if (value.Equals("")) throw new ArgumentException("Broj pokusaja je obavezno.", nameof(broj_pokusaja));
                broj_pokusaja = value;
            }
        }
        public string Opis
        {
            get { return opis; }
            set
            {
                opis = value;
            }
        }
    }
}
