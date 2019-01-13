using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace FarmAssist_02
{
    class BPLijecenje
    {
        public static void Spremi(Ljecenje l)
        {

            BP.otvoriKonekciju();
            SQLiteCommand command = BP.konekcija.CreateCommand();
            command.CommandText = String.Format(@"insert into Ljecenje(Naziv_bolesti, datumi_svih_cijepljenja, Naziv_cjepiva, Trajanje_bolesti, Prehrana_lijecenje)
                                                 values ({0}, {1}, {2}, {3}, {4})",
                                                 l.naziv_bolesti, l.datumi_svih_cijepljenja, l.naziv_cjepiva, l.trajanje_bolesti, l.prehrana_lijecenje );

            command.ExecuteNonQuery();
            command.Dispose();
            BP.zatvoriKonekciju();

        }
    }
}
