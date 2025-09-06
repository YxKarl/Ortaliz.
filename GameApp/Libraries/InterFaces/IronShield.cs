using GameApp.Libraries.Abstract;

namespace GameApp.Libraries.Interfaces
{   // This Code is for IronShield
    public class IronShield : GameItem
    {
        public int Defense;
        public IronShield(String itemName, int defense) : base(itemName)
        {
            this.Defense = defense;
        }

        public override void UseItem()
        {
            Console.WriteLine("You equip the Iron Shield " + "Defense increased by " + this.Defense);
        }
    }
}