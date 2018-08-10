using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DQ10_Discord.Program;
using static DQ10_Discord.Weapon;
using static DQ10_Discord.Area;

namespace DQ10_Discord
{
    class Status
    {
        public static int EXP;
        public static int GOLD;
        public static int HP;
        public static int MP;
        public static int ATK; 
        public static int DEF;
        public static int Weght;
        public static String mes2;
        public static String grave = "```";

        public static void MonsterStatus()

        {
            if (mes == "スライム") {
                EXP = 2;
                GOLD = 1;
                HP = 5;
                MP = 2;
                ATK = 9;
                DEF = 11;
                Weght = 80;
                mes2 = grave + "スライム";
                mes2 += "\n" + "経験値:"+EXP;
                mes2 += "\n" + "ゴールド:" + GOLD;
                mes2 += "\n"+ "HP:" + HP;
                mes2 += "\n" +"MP:" + MP;
                mes2 += "\n" +"ATK:" + ATK;
                mes2 += "\n" +"DEF:" + DEF;
                mes2 += "\n" +"重さ:" + Weght;
                mes2 += "\n\n" + "ドロップアイテム:";

                mes2 += "\n\n" + "装備";
                mes2 += "\n" + Sword[1];
                mes2 += "\n" +"白木のおうぎ";
                mes2 += "\n" + "皮の盾";
                mes2 += "\n" + "前座芸人の服";
                mes2 += "\n" +"前座芸人のながぐつ";
                mes2 += "\n\n" +"宝珠";
                mes2 += "\n" +"なし";
                mes2 += "\n\n" +"出現場所";
                mes2 += "\n" + Orgreede[1];
                mes2 += "\n" + Eltona[1];
                mes2 += "\n" + Dwachakka[1];
                mes2 += "\n" + Dwachakka[2];
                mes2 += "\n" + Pukland[1];
                mes2 += "\n" + Wenna[1];
                mes2 += "\n" + "育みの大地[偽]";
                mes2 += "\n" + "育みの大地[真]";
                mes2 += "\n" + "サザミレ草原";
                mes2 += "\n" + "エテーネ王国領";
                mes2 += "\n" + "辺境の雪山" + grave;

            }
            if (mes == "スライムベス")
            {

                mes2 =  "Test";



            }

        }
    
    
    }
}
