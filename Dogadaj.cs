using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace FarmAssist_02

{
    public class Dogadaj
    {
        private long id;
        private DateTime datum;
        private string opis;
        private string mjesto;


        public Dogadaj()
        {
            id = -1;
        }

        public DateTime Datum
        {
            get
            {
                return datum;
            }

            set
            {
                datum = value;
            }
        }

        public string Opis
        {
            get
            {
                return opis;
            }

            set
            {
                opis = value;
            }
        }



        public string Mjesto
        {
            get
            {
                return mjesto;
            }

            set
            {
                mjesto = value;
            }
        }

        public long Id
        {
            get
            {
                return Id1;
            }

            set
            {
                Id1 = value;
            }
        }

        public long Id1
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
