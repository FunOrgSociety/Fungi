using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace FarmAssist_02
{
    class Govedo
    {
        public string hb;
        public string mb;
        public string ime_krave;
        public DateTime godina_teljenja;
        public decimal tezina_goveda { get; set; }
        public string pasmina;
        public string Spol { get; set; }
        public string hb_oca;
        public string mb_oca;
        public string hb_majke;
        public string mb_majke;

        public string HB
        {
            get { return hb; }
            set
            {
                if (value.Equals("")) throw new ArgumentException("HB je obavezno.", nameof(hb));
                hb = value;
            }
        }
        public string MB
        {
            get { return mb; }
            set {
                if (value.Equals("")) throw new ArgumentException("MB je obavezno.", nameof(mb));
                mb = value;
            }
        }
        public string Ime_krave
        {
            get { return ime_krave; }
            set
            {
                if (value.Equals("")) throw new ArgumentException("Ime krave je obavezno.", nameof(ime_krave));
                ime_krave = value;
            }
        }
        public DateTime Godina_teljenja
        {
            get { return godina_teljenja; }
            set
            {
                if (value.Equals("")) throw new ArgumentException("Godina teljenja je obavezno.", nameof(godina_teljenja));
                godina_teljenja = value;
            }
        }
        
         
        public string Pasmina
        {
            get { return pasmina; }
            set
            {
                if (value.Equals("")) throw new ArgumentException("Pasmina je obavezno.", nameof(pasmina));
                pasmina = value;
            }
        }
        public string HB_oca
        {
            get { return hb_oca; }
            set
            {
                if (value.Equals("")) throw new ArgumentException("HB_oca je obavezno.", nameof(hb_oca));
                hb_oca = value;
            }
        }
        public string MB_oca
        {
            get { return mb_oca; }
            set
            {
                if (value.Equals("")) throw new ArgumentException("MB_oca je obavezno.", nameof(mb_oca));
                mb_oca = value;
            }
        }
        public string HB_majke
        {
            get { return hb_majke; }
            set
            {
                if (value.Equals("")) throw new ArgumentException("HB_majke je obavezno.", nameof(hb_majke));
                hb_majke = value;
            }
        }
        public string MB_majke
        {
            get { return mb_majke; }
            set
            {
                if (value.Equals("")) throw new ArgumentException("MB_majke je obavezno.", nameof(mb_majke));
                mb_majke = value;
            }
        }

    }


}
