using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace FarmAssist_02
{
    class BPTele
    {
        public static void Spremi(Tele t)
        {

            BP.otvoriKonekciju();
            SQLiteCommand command = BP.konekcija.CreateCommand();
            command.CommandText = String.Format(@"insert into Tele(Porod, HB_teleta, spol_teleta, HB_bika,datum_gonjenja, Broj_pokusaja, Opis)
                                    values('{0}', '{1}','{2}','{3}', '{4}','{5}', '{6}')",
                                    t.porod, t.hb_teleta,t.spol_teleta, t.hb_bika, t.datum_gonjenja, t.broj_pokusaja, t.opis);
            command.ExecuteNonQuery();
            command.Dispose();
            BP.zatvoriKonekciju();


        }
    }
}
