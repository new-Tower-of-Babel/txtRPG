using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace txtRPG
{
    class GameDisplay
    {
        Player player = new Player(); 
        Item item = new Item();
        
        public static GameDisplay instance;
        public static GameDisplay DisplayInstance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameDisplay();
                }
                return instance;
            }
        }
        public void DisplayInventory()
        {
            if (player.Inventory.Count == 0)
            {
                Console.WriteLine("인벤토리가 비어 있습니다.");
            }
            else
            {
                Console.WriteLine("인벤토리:");
                foreach (var item in player.Inventory)
                {
                    Console.WriteLine($"- {item.itemName} (가격: {item.itemPrice} G)");
                }
            }
        }
        public void setGame()
        {
            Console.WriteLine("플레이어의 이름을 입력하세요:");
            player.Name = Console.ReadLine();

            Console.WriteLine("직업을 선택하세요 (숫자를 입력하세요):");
            Console.WriteLine("1. 전사\n2. 마법사\n3. 궁수");
            string jobChoice = Console.ReadLine();

            switch (jobChoice)
            {
                case "1":
                    player.Job = "전사";
                    break;
                case "2":
                    player.Job = "마법사";
                    break;
                case "3":
                    player.Job = "궁수";
                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다. 기본 직업으로 '전사'가 선택됩니다.");
                    player.Job = "전사";
                    break;
            }

            StartGame();
        }
        public void StartGame()
        {
            Console.Clear();
            Console.WriteLine("환영합니다! 게임이 시작되었습니다.");
            Console.WriteLine("마을에서 할 수 있는 행동:");
            Console.WriteLine("1. 상태 보기\n2. 인벤토리\n3. 상점");

            string action = Console.ReadLine();

            switch (action)
            {
                case "1":
                    player.DisplayStatus();
                    break;
                case "2":
                    DisplayInventory();
                    break;
                case "3":
                    item.itemShow();
                    break;
                default:
                    Console.WriteLine("잘못된 선택입니다.");
                    break;
            }

        }

}
}
