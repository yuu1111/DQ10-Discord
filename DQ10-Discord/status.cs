using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if (Program.mes == "スライム") {
                EXP = 2;
                GOLD = 1;
                HP = 5;
                MP = 2;
                ATK = 9;
                DEF = 11;
                Weght = 80;
                mes2 = grave+ "スライム\n経験値:"+EXP+"P\nゴールド:"+GOLD+"G\n";
                mes2 += "\nHP:"+HP+"\nMP:"+MP+"\nATK:"+ATK+"\nDEF:"+DEF+"\n重さ:"+Weght+"\n";
                mes2 += "\n装備\n"+ Weapon.Sword[1] + "\n白木のおうぎ\n皮の盾\n前座芸人の服\n前座芸人のながぐつ\n";
                mes2 += "\n宝珠\nなし\n";
                mes2 += "\n出現場所";
                mes2 += "\n" + Area.Orgreede[1] + " プクレット地方 アクロニア鉱山 ラニアッカ断層帯";
                mes2 += "\nツスクル平野 コルット地方 育みの大地[偽] 真の育みの大地 サザミレ草原 \n";
                mes2 += "エテーネ王国領 辺境の雪山" + grave;

            }
            if (Program.mes == "スライムベス")
            {

                mes2 =  "Test";



            }

        }
    
    
    }
}
