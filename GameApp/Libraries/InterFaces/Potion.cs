using GameApp.Libraries.Abstract;

namespace GameApp.Libraries.Interfaces
{   // This Code is for Potion
    public class Potion : GameItem
    {
        public int HealingAmount;
        public Potion(String itemName, int healingAmount) : base(itemName)
        {
            this.HealingAmount = healingAmount;
        }

        public override void UseItem()
        {
            Console.WriteLine("You drank the Health Potion." + ".Health restored by " + this.HealingAmount + " points.");
        }
    }
}