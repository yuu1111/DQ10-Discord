using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DQ10_Discord
{
    class status
    {

        public static String mes2;
        public static String grave = "```";
        public static void MonsterStatus()
        {

            if (Program.mes == "スライム") {

                mes2 = grave+ "スライム\n経験値:2P\nゴールド:1G\n";
                mes2 += "\nHP:5\nMP:2\nATK:9\nDEF:11\n重さ80\n";
                mes2 += "\n装備\nどうのつるぎ\n白木のおうぎ\n皮の盾\n前座芸人の服\n前座芸人のながぐつ\n";
                mes2 += "\n宝珠\nなし" + grave;


            }

        }
    
    
    }
}
