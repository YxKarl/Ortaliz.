using GameApp.Libraries.Interfaces;

namespace GameApp.Libraries.Abstract
{
    public abstract class GameItem
    { // Abstract class for Game Items
        public String Name;
        public GameItem(string itemName)
        {
            this.Name = itemName;
        }
        public void ShowInfo()
        {
            Console.WriteLine("Item: " + Name);
        }
        public abstract void UseItem();
    }
}