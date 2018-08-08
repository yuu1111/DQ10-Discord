﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DQ10_Discord
{
    class Weapon
    {


        public static Dictionary<int, string> Sword = new Dictionary<int, string>()
        {
            {0, "初心者用の片手剣"},
            {1, "どうのつるぎ"},
            {2, "せいどうのつるぎ"},
            {3, "レイピア"},
            {4, "てつのつるぎ"},
            {5, "さんぞくのサーベル"},
            {6, "ぎんのレイピア"},
            {7, "バスターソード"},
            {8, "はがねのつるぎ"},
            {9, "ウェスタンレイピア"},
            {10, "戦士の剣"},
            {11, "はじゃのつるぎ"},
            {12, "はやぶさの剣"},
            {13, "プラチナソード"},
            {14, "まけんしのレイピア"},
            {15, "ゾンビキラー"},
            {16, "ドラゴンキラー"},
            {17, "ほのおのつるぎ"},
            {18, "きせきのつるぎ"},
            {19, "メタスラの剣"},
            {20, "オニキスの魔剣"},
            {21, "ほしくずのつるぎ"},
            {22, "聖王のつるぎ"},
            {23, "ライトニングソード"},
            {24, "名刀 斬鉄丸"},
            {25, "天命のつるぎ"},
            {26, "戦姫のレイピア"},
            {27, "はやぶさの剣改"},
            {28, "セイクリッドソード"},
            {29, "天恵石のつるぎ"},
            {30, "アカシックソード"},
         };

        public static Dictionary<int, string> TwoSword = new Dictionary<int, string>()
        {
            {0, "初心者用の両手剣"},
            {1, "どうの大剣"},
            {2, "せいどうの大剣"},
            {3, "ビッグブレード"},
            {4, "てつの大剣"},
            {5, "ビッグブレードⅡ"},
            {6, "シャドウエッジ"},
            {7, "おおばさみ"},
            {8, "はがねの大剣"},
            {9, "退魔の太刀"},
            {10, "ブラッドエッジ"},
            {11, "クレセントエッジ"},
            {12, "斬夜の太刀"},
            {13, "プラチナブレード"},
            {14, "デーモンバスター"},
            {15, "ドラゴンバスター"},
            {16, "キングブレード"},
            {17, "大獄剣"},
            {18, "メタスラの大剣"},
            {19, "天馬の大剣"},
            {20, "フォースブレード"},
            {21, "聖王の大剣"},
            {22, "エンパイアブレード"},
            {23, "ケイオスブレード"},
            {24, "翠石の大剣"},
            {25, "スレイプニール"},
            {26, "フューリーブレード"},
            {27, "聖大剣アスカロン"},
            {28, "オートクレール"},
            {29, "神域の大剣"},
        };

        public static Dictionary<int, string> Dagger = new Dictionary<int, string>()
        {
            {0, "初心者用の短剣"},
            {1, "ブロンズナイフ"},
            {2, "聖なるナイフ"},
            {3, "どくがのナイフ"},
            {4, "シーブスナイフ"},
            {5, "アサシンダガー"},
            {6, "ぎんの短剣"},
            {7, "どくばり"},
            {8, "こあくまのナイフ"},
            {9, "イーグルダガー"},
            {10, "キラーピアス"},
            {11, "よるのパピヨン"},
            {12, "ソードブレイカー"},
            {13, "こおりのやいば"},
            {14, "グラディウス"},
            {15, "ブラッドピック"},
            {16, "王家のナイフ"},
            {17, "サラマンダー"},
            {18, "ファルコンダガー"},
            {19, "こがあらしのダガー"},
            {20, "サウザンドダガー"},
            {21, "聖王のナイフ"},
            {22, "ライトニングダガー"},
            {23, "ポイズンスケイル"},
            {24, "クリスタルエッジ"},
            {25, "エンシャントククリ"},
            {26, "天河のジャンビーヤ"},
            {27, "トールナイフ"},
            {28, "ガテリアの宝剣"},
            {29, "神域の短剣"},
        };

        public static Dictionary<int, string> Stick = new Dictionary<int, string>()
        {
            {0, "初心者用のスティック"},
            {1, "ローリエの小枝"},
            {2, "ピンスティック"},
            {3, "フラワースティック"},
            {4, "スライムステッキ"},
            {5, "ツインクルタクト"},
            {6, "モーモンスティック"},
            {7, "フェザースティック"},
            {8, "ラブリースティック"},
            {9, "スラタワースティック"},
            {10, "まてきのスティック"},
            {11, "マジカルスティック"},
            {12, "マポレーナステッキ"},
            {13, "ペロリンステッキ"},
            {14, "パラソルスティック"},
            {15, "ドラゴンスティック"},
            {16, "ユグドラシル"},
            {17, "天使のタクト"},
            {18, "あくまのタクト"},
            {19, "ゴシックパラソル"},
            {20, "タイタニアスステッキ"},
            {21, "聖王のスティック"},
            {22, "ひかりのタクト"},
            {23, "ファンタスティック"},
            {24, "ラクリマタクト"},
            {25, "エンシェントタクト"},
            {26, "栄華の王錫"},
            {27, "リトルフェザー"},
            {28, "バージニアステッキ"},
            {29, "双月のスティック"},
        };

        public static Dictionary<int, string> Cane = new Dictionary<int, string>()
        {
            {0, "初心者用の両手杖"},
            {1, "かしの杖"},
            {2, "まどうしの杖"},
            {3, "さばきの杖"},
            {4, "あまぐもの杖"},
            {5, "まふうじの杖"},
            {6, "うみなりの杖"},
            {7, "ようせいの杖"},
            {8, "いかずちの杖"},
            {9, "ピオラの杖"},
            {10, "ルーンスタッフ"},
            {11, "マグマの杖"},
            {12, "せいれいの杖"},
            {13, "まがんの杖"},
            {14, "こおりの杖"},
            {15, "セイレーンの杖"},
            {16, "アークワンド"},
            {17, "福音の杖"},
            {18, "賢者の杖"},
            {19, "女神の杖"},
            {20, "ドラゴンの杖"},
            {21, "聖王の杖"},
            {22, "ひかりの杖"},
            {23, "イーリスの杖"},
            {24, "不死者の魔杖"},
            {25, "万物流転の杖"},
            {26, "邪術皇の杖"},
            {27, "エンシェントワンド"},
            {28, "天恵石の杖"},
            {29, "神域の杖"},
        };



    }
}
