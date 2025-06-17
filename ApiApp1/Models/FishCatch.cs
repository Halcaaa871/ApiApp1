//魚のモデル作成

namespace ApiApp1.Models
{
    public class FishCatch
    {
        public int Id { get; set; }
        /*  初期値の設定のstring.Empty
         *  1.nullを避けるため
         *  2.string型がnullにならないことを期待される型だから
         *  3.明示的な意図の表現
         */
        public string Name { get; set; } = string.Empty;


        public double Size { get; set; }//～cm
        public string Rarity { get; set; } = "Common";
        public DateTime CaughtAt { get; set; } = DateTime.Now;
    }
}
