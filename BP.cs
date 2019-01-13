using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace FarmAssist_02
{
    class BP
    {
        private static string connectionString = "URI=file:FarmAssist.db";

        internal static SQLiteConnection konekcija = new SQLiteConnection(connectionString);

        public static void otvoriKonekciju()
        {
            konekcija.Open();

            var cmd = konekcija.CreateCommand();


             cmd.CommandText = @"CREATE	TABLE	IF	NOT	EXISTS	Govedo(hb varchar(20), mb varchar(20), ime_krave varchar(20), godina_teljenja datetime, tezina_goveda numeric,
                                pasmina varchar(20), spol varchar(20), hb_oca varchar(20), mb_oca varchar(20), hb_majke varchar(20), mb_majke varchar(20))";


             cmd.ExecuteNonQuery();

             cmd.CommandText = @"CREATE	TABLE	IF	NOT	EXISTS	Tele(Porod DateTime, HB_teleta varchar (20), Spol_teleta varchar(20), HB_bika varchar(20),
                                        datum_gonjenja DateTime, Broj_pokusaja integer, Opis varchar(200))";
             cmd.ExecuteNonQuery();
             cmd.CommandText = @"CREATE	TABLE	IF	NOT	EXISTS	Ljecenje(Naziv_bolesti varchar(50), datumi_svih_cijepljenja DateTime,
                                        Naziv_cjepiva varchar(20), Trajanje_bolesti integer, Prehrana_lijecenje varchar(200))";
             cmd.ExecuteNonQuery();
            cmd.CommandText = @"CREATE	TABLE	IF	NOT	EXISTS	dogadaj(opis varchar(200), datum DateTime, vrijeme DataTime, mjesto varchar(20))";

            cmd.ExecuteNonQuery();
        }

        public static void zatvoriKonekciju()
        {
            konekcija.Close();
        }
    }
}
