using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
namespace FarmAssist_02
{
    class BPGovedo
    {
        
        public static void Spremi(Govedo g)
        {

            BP.otvoriKonekciju();
            SQLiteCommand command = BP.konekcija.CreateCommand();
            command.CommandText = String.Format (@"insert into Govedo(hb, mb, ime_krave, godina_teljenja, tezina_goveda, pasmina, Spol, hb_oca, mb_oca, hb_majke, mb_majke)
                                    values('{0}', '{1}','{2}','{3}', '{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                                    g.HB, g.MB, g.ime_krave, g.godina_teljenja, g.tezina_goveda, g.pasmina, g.Spol, g.HB_oca, g.mb_oca, g.hb_majke, g.mb_majke);
            command.ExecuteNonQuery();
            command.Dispose();
            BP.zatvoriKonekciju();
        
        }
        
    }
}
 