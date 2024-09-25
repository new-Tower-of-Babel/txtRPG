using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace txtRPG
{
    public class Itemtable
    {        
        public int itemnum { get; set; }
        public string itemName { get; set; }
        public int itemPrice { get; set; }
        public int itemAtkPoint { get; set; }
        public int itemDfsPoint { get; set; }

        public enum itemRank { bronze_Rank = 1, silver_Rank = 2, gold_Rank = 3, diamond_Rank = 4 }
        public void WeaponItem(itemRank itemRank)
        {
            itemnum=100+(int)itemRank;
            itemName = itemRank.ToString()+" Weapon";
            itemAtkPoint=(int)itemRank;
            itemPrice = (int)itemRank*100;
        }
        public void ArmorItem(itemRank itemRank)
        {
            itemnum=200+(int)itemRank;
            itemName = itemRank.ToString()+" Armor";
            itemDfsPoint=(int)itemRank*10;
            itemPrice =(int)itemRank*100;
        }
    }
    public class Item
    {
        List<Itemtable> weaponItem = new List<Itemtable>();
        List<Itemtable> armorItem = new List<Itemtable>();

        public void itemSet()
        {
            foreach (Itemtable.itemRank itemtable in Enum.GetValues(typeof(Itemtable.itemRank)))
            {
                Itemtable item = new Itemtable();
                item.WeaponItem(itemtable);
                weaponItem.Add(item);
            }
            foreach (Itemtable.itemRank itemtable in Enum.GetValues(typeof(Itemtable.itemRank)))
            {
                Itemtable item = new Itemtable();
                item.ArmorItem(itemtable);
                armorItem.Add(item);
            }
        }
        public Item()
        { 
        itemSet();
        }
        public void itemShow()
        {
            Console.Clear();
            foreach (Itemtable item in weaponItem)
            {
                Console.WriteLine($"아이템넘버 : {item.itemnum} | 이름 : {item.itemName,-20} | 공격력 : {item.itemAtkPoint,-10} | 가격 : {item.itemPrice}");
            }
            foreach (Itemtable item in armorItem)
            {
                Console.WriteLine($"아이템넘버 : {item.itemnum} | 이름 : {item.itemName,-20} | 방어력 : {item.itemDfsPoint,-10} | 가격 : {item.itemPrice}");
            }
            Console.WriteLine("\n\n나가기 : 0");
            int outKey = int.Parse(Console.ReadLine());
            if (outKey==0)
            {
                GameDisplay.instance.StartGame();
            }
        }
        //아이템구매
        //public bool BuyItem(Item item)
        //{
        //    if (Player.instance.Gold >= weaponItem.)
        //    {
        //        Player.instance.Gold -= item.Price;
        //        Player.instance.Inventory.Add();
        //        Console.WriteLine($"{}을(를) 구매했습니다!");
        //        return true;
        //    }
        //    else
        //    {
        //        Console.WriteLine("소지금이 부족합니다.");
        //        return false;
        //    }
        //}

    }
}
