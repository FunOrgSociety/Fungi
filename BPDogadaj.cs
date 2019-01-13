using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace FarmAssist_02
{
    public static class BPDogadaj
    {
        //Funkcija koja sprema događaj koji joj je dan kao argument
        public static void SpremiDogadaj(Dogadaj d)
        {
            BP.otvoriKonekciju();

            //Kreiranje komande
            SQLiteCommand command = BP.konekcija.CreateCommand();

            //Dodjeljivanje SQL upita prethodno kreiranoj komandi
            command.CommandText = String.Format(@"Insert into dogadaj (opis,mjesto,datum )
			Values ('{0}', '{1}' , '{2}')", d.Opis, d.Mjesto, d.Datum.ToFileTime());

            //Izvrsavanja komande
            command.ExecuteNonQuery();

            //"Ciscenje" komande
            command.Dispose();

            BP.zatvoriKonekciju();
        }

        //Funkcija koja izmjenjuje događaj koji joj je dan kao argument
        public static void IzmjeniDogadaj(Dogadaj d)
        {
            BP.otvoriKonekciju();

            //Kreiranje komande
            SQLiteCommand command = BP.konekcija.CreateCommand();

            //Dodjeljivanje SQL upita prethodno kreiranoj komandi
            command.CommandText = String.Format(@"Update dogadaj
			set opis = '{0}', mjesto = '{1}' , datum = '{2}'
			where id = '{5}'", d.Opis, d.Mjesto, d.Datum.ToFileTime());

            //Izvrsavanja komande
            command.ExecuteNonQuery();

            //"Ciscenje" komande
            command.Dispose();

            BP.zatvoriKonekciju();
        }

        public static void IzbrisiDatum(long id)
        {
            BP.otvoriKonekciju();

            SQLiteCommand command = BP.konekcija.CreateCommand();

            command.CommandText = String.Format(@"Delete from dogadaj Where id = '{0}'", id);

            command.ExecuteNonQuery();

            command.Dispose();

            BP.zatvoriKonekciju();
        }

        public static List<Dogadaj> DohavtiSve()
        {
            BP.otvoriKonekciju();

            List<Dogadaj> listaDogadaja = new List<Dogadaj>();

            SQLiteCommand command = BP.konekcija.CreateCommand();

            //Umetanje podataka u tablicu
            command.CommandText = "Select * from dogadaj";

            SQLiteDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                Dogadaj temp = new Dogadaj();

                //temp.Datum = DateTime.FromFileTime(reader.GetInt64(2));
                temp.Id = (int)(Int64)reader["id"];
                temp.Datum = DateTime.FromFileTime(reader.GetInt64(1));
                temp.Opis = (string)reader["opis"];
                temp.Datum = DateTime.FromFileTime(reader.GetInt64(1));
                temp.Mjesto = (string)reader["mjesto"];


                listaDogadaja.Add(temp);
            }

            reader.Dispose();
            command.Dispose();

            BP.zatvoriKonekciju();

            return listaDogadaja;
        }
    }
}
