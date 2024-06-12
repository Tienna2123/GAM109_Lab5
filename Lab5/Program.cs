using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class UserAccountLab5
    {
        public string name;
        public int rank;
        public float winRate;
        public string type;
        public int skin;

        public UserAccountLab5(string name, int rank, float winRate, string type, int skin)
        {
            this.name = name;
            this.rank = rank;
            this.winRate = winRate;
            this.type = type;
            this.skin = skin;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            List<UserAccountLab5> list = new List<UserAccountLab5>();
            list.Add(new UserAccountLab5("Sơn Tùng", 10, 55.5f, "Ca Nhạc", 50));
            list.Add(new UserAccountLab5("Hoàng Thùy Linh", 9, 60.5f, "Ca Nhạc", 40));
            list.Add(new UserAccountLab5("Vũ Cát Tường", 8, 65.5f, "Ca Nhạc", 30));
            list.Add(new UserAccountLab5("Hương Tràm", 7, 70.5f, "Ca Nhạc", 20));
            list.Add(new UserAccountLab5("Độ Mixi", 6, 33.50f, "Live Stream", 10));
            list.Add(new UserAccountLab5("PewPew", 5, 80.5f, "Live Stream", 5));
            list.Add(new UserAccountLab5("Misthy", 4, 22.5f, "Live Stream", 4));
            list.Add(new UserAccountLab5("Pinky", 3, 90.5f, "Live Stream", 3));
            list.Add(new UserAccountLab5("Dev Nguyễn", 10, 95.5f, "Game", 250));

            //a) in danh sách User
            foreach (var player in list)
            {
                Console.WriteLine($"Ten: {player.name}, Rank: {player.rank}, Skin: {player.skin}");
            }
            Console.WriteLine("--------------");

            //b) Sắp xếp theo rank giảm dần
            var sorted1 = list.OrderBy(x => x.winRate);

            foreach (var player in sorted1)
            {
                Console.WriteLine($"Ten: {player.name}, Rank: {player.rank}, Skin: {player.skin}");
            }
            Console.WriteLine("--------------");

            //c) Sắp xếp theo user và skin
            var sorted2 = list.OrderBy(x => x.name).ThenBy(x => x.skin);
            foreach (var player in sorted2)
            {
                Console.WriteLine($"Ten: {player.name}, Rank: {player.rank}, Skin: {player.skin}");
            }
            Console.WriteLine("--------------");

            //d) Lọc người chơi theo chữ cái đầu tiên
            var filteredName = list.Where(x => x.name.StartsWith("H"));
            foreach (var player in filteredName)
            {
                Console.WriteLine($"Ten: {player.name}, Rank: {player.rank}, Skin: {player.skin}");
            }
            

        }
    }
}
