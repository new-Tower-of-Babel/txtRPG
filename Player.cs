using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txtRPG
{
    
    public class Player
    {
        public static Player instance;
        public static Player PlayerInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Player();
                }
                return instance;
            }
        }

        public string Name { get; set; }
        public string Job { get; set; }
        public int Level { get; set; } = 1;
        public int AttackPower { get; set; } = 10;
        public int DefensePower { get; set; } = 5;
        public int Health { get; set; } = 100;
        public int Gold { get; set; } = 1500;
        public List<Itemtable> Inventory { get; set; } = new List<Itemtable>();

        // 플레이어 정보 출력
        public void DisplayStatus()
        {
            Console.Clear();
            Console.WriteLine($"Lv. {Level}");
            Console.WriteLine($"{Name} ({Job})");
            Console.WriteLine($"공격력: {AttackPower}");
            Console.WriteLine($"방어력: {DefensePower}");
            Console.WriteLine($"체력: {Health}");
            Console.WriteLine($"소지금: {Gold} G");
            Console.WriteLine("\n\n나가기 : 0");
            int outKey = int.Parse(Console.ReadLine());
            if (outKey==0)
            {
                GameDisplay.instance.StartGame();
            }
        }
    }
}
